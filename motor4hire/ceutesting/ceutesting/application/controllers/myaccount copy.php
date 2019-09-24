<?php
/**
 * controller to display a user custom profile and allow the owner of the 
 * profile to modify it
 * @author Daniel Vecchiato
 * @link 4webby.com
 */
class Myaccount extends Controller 
{
	function Myaccount()
	{
		parent::Controller();
		//Set template pages and views
        $this->_page = $this->config->item('FAL_template_dir').'template_admin/myaccount_container';
	}
	
	// -------------------------------------------------------------------- 
	function index()
	{
		//write the code to display a list of all registered users here
	}
	
	// -----------------------------------------------
	/**
	 * display the profile of an requested user
	 * we let everybody see this profile
	 */
	function show()
	{
		$id = $this->uri->segment(4);
    	$query = $this->usermodel->getUserById($id);
		
		if ($query->num_rows() == 1)
        {
			$row = $query->row();
			$data['user']['id']= $row->id;
			$data['user']['user_name']= $row->user_name;
			$data['user']['email']= $row->email;
			
			//$countries = null;            
		    if ($this->config->item('FAL_use_country') && strlen($row->country_id))
		    {
		    	$this->load->model('country'); 
		        
		    	$query = $this->country->getCountryById($row->country_id);
		    	$row = $query->row();
		    		
		    	//SELECT name FROM country WHERE id= $data['user']['country_id']
		        $data['user']['country'] = $row->name;
		    }
		    
		    $query->free_result();
		    
		    //
		    if ($this->config->item('FAL_create_user_profile')==TRUE)
		    {
		    	//get data from the user_profile table
		    	$data['user_profile']= $this->freakauth_light->_getUserProfile($id);
		    	//$data['f_r'] = $this->freakauth_light->_buildUserProfileFieldsRules();
		    	//$data['label'] = $data['f_r']['fields']; 
		    }
		    
        }
        else 
        {
        	$data['error_message']='The record you are looking for does not exist';
        }
    	
	    	$this->load->view('view', $data);
	}
	
	// -----------------------------------------------
	/**
	 * necessary for the user to edit his own profile
	 * only the user owning this profile can access this method
	 * 
	 * We allow him to edit everything apart from his username that must be unique
	 * and therefore not changed after registration
	 */
	function edit()
	{
		$this->heading = 'Edit Email and Password &raquo; Profile';
		//www.yourdomain.com/index.php/myaccount/edit/1
		$id = $this->uri->segment(3);
		
		//let's restrict access to just the owner of this account
		//if number and number==userdata['id']
		if (belongsToGroup('user') AND $id === $this->db_session->userdata('id'))
		{
			//loading necessary stuff
			$this->lang->load('freakauth');
	        $this->load->model('FreakAuth_light/usermodel', 'usermodel');
	        $this->load->library('validation');
			$this->validation->set_error_delimiters($this->config->item('FAL_error_delimiter_open'), $this->config->item('FAL_error_delimiter_close'));
			
	    	//set validation rules
	        $rules['password'] = 'trim|xss_clean|callback__password_check';
	        $rules['password_confirm'] = "trim|xss_clean|matches[password]";
	        $rules['email'] = 'trim|required|valid_email|xss_clean|callback__email_duplicate_check';
			
		}
		else 
		{
			$msg = 'your must login to access this restricted area';
        	$this->db_session->set_flashdata('flashMessage', $msg, 1);
			redirect('' , 'location');
			
		}
        
        //do we want to set the country?
        //(looks what we set in the freakauth_light.php config)
        if ($this->config->item('FAL_use_country'))
        {
            $rules['country_id'] = $this->config->item('FAL_user_country_field_validation_register');
        }
            
        //getting user profile custom data and setting fields and rules for validation
	    if ($this->config->item('FAL_create_user_profile')==TRUE)
		{	
		    //$data = $this->freakauth_light->_buildUserProfileFieldsRules();
		    //$rules_profile= $data['rules'];
		    //$fields = $data['fields']; 
		    //$this->validation->set_rules($rules_profile);
		}
        
        $this->validation->set_rules($rules);
        
        $fields['password'] = $this->lang->line('FAL_user_password_label');
        $fields['password_confirm'] = $this->lang->line('FAL_user_password_confirm_label');
        $fields['email'] = $this->lang->line('FAL_user_email_label');
        
        //if activated in config, sets the select country box
        if ($this->config->item('FAL_use_country'))
        {
            $fields['country_id'] = $this->lang->line('FAL_user_country_label');
        }
        
        $this->validation->set_fields($fields);
        
    	//this avoid 1 extra query if validation doesn't return true
        if ($id!='')
        {	
        	//gets values for the edit form
        	$query = $this->usermodel->getUserById($id);
        
		
	       	foreach ($query->result() as $row)
		        	{
		        		$data['user']['id']= $row->id;
		        		$data['user']['email']= $row->email;
		        		$data['user']['country_id']= $row->country_id;
		        	}
		        	
		    $query->free_result();
		    
		    

		    if ($this->config->item('FAL_create_user_profile')==TRUE)
			{
				$data['user_prof']= $this->freakauth_light->_getUserProfile($id);
		    	//$data['f_r'] = $this->freakauth_light->_buildUserProfileFieldsRules();
		    	//$data['fields'] = $data['f_r']['fields']; 
			}
		    
	    }

	    //$countries = null;            
	    if ($this->config->item('FAL_use_country'))
	    {
	    	$this->load->model('country'); 
	        	
	    	//SELECT * FROM country
	        $data['countries'] = $this->country->getCountriesForSelect();
	    }
	    	  	
		if ($this->validation->run() == FALSE)
        {
	        	$data['page_class'] = 'myaccount';
				$this->load->view($this->_page, $data);
        }
    	
		//if everything ok
		else
		{			
			//get form values
			$values = $this->_get_form_values();
			
			$id = $this->db_session->userdata('id');
			
			//update data in DB
			$where=array('id' => $id);
        	$this->usermodel->updateUser($where, $values['user']);
        	
        	//if we want the user profile as well
	        if($this->config->item('FAL_create_user_profile'))
	        {	
	              //let's get the last insert id
	              //$this->load->model('Userprofile');
	              //$this->Userprofile->updateUserProfile($id, $values['user_profile']);
	        }
        	//set a flash message
			$msg = $this->db->affected_rows().$this->lang->line('FAL_user_edited');
        	$this->db_session->set_flashdata('flashMessage', $msg, 1);
			
			//redirect to list
			redirect('dashboard/profile/'.$this->db_session->userdata('id'), 'location');
		}
	}
	
	    // -------------------------------------------------------------------- 
    
    /**
     * Checks if form $_POST data are set and valid
     * assigns the $_POST data to an array and returns it
     *
     * @return array of form values
     */
    function _get_form_values()
    {

        $values['user']['password'] = $this->input->post('password');
        $values['user']['email'] = $this->input->post('email');
        $values['user']['country_id'] = $this->input->post('country_id');

		
		//let's get the custom user profile  values
		if ($this->config->item('FAL_create_user_profile')==TRUE)
		{	
		    $this->load->model('Userprofile', 'userprofile');
		    
		    //array of fields
  			$db_fields=$this->userprofile->getTableFields();

  			//number of DB fields -1
  			//I put a -1 because I must subtract the 'id' field
  			$num_db_fields=count($db_fields) - 1;
  		
  			//I use 'for' instead of 'foreach' because I have to escape the 'id' field that has key=0 in my array
	  		for ($i=1; $i<=$num_db_fields;  $i++)
			{
				$values['user_profile'][$db_fields[$i]]=$this->input->post($db_fields[$i]);
			}
		 }


        if (!empty($values))
        {
            //necessary if password is not reset in edit()
        	if ($values['user']['password'] !='')  
            {
	        	$password = $values['user']['password'];
	        	//encrypts the password (md5)
	        	$values['user']['password'] = $this->freakauth_light->_encode($password);
            }
            else 
            {
            	unset($values['user']['password']);
            }

        	return $values;
        }
        
        return false;
    }

	// --------------------------------------------------------------------
        
    /**
     * RULES HELPER FUNCTION
     * checks if a password has been specified
     * 
     * @param form value $value
     * @return boolean
     */
	function _password_check($value)
	{	
		if ($value='' AND isset($_POST['id']))
		{
			$callback = '_password_check';
			return $this->_is_valid_text($callback, $value, $this->config->item('FAL_user_password_min'), $this->config->item('FAL_user_password_max'));
		}
	   
	}
	
	// --------------------------------------------------------------------
	
    /**
     * RULES HELPER FUNCTION
     * User name duplicate validation callback for validation against duplicate e_mail in DB
     *
     * @access private
     * @param varchar $value
     * @return boolean
     */
    function _email_duplicate_check($value)
	{ 	
		$id = $this->db_session->userdata('id');
		
		//Use the input e-mail and check against 'users' table
		//query in main user table (users already activated)
	    
		$fields='id';
		$where = array('id !=' => $id, 'email'=>$value);
        $query = $this->usermodel->getUsers($fields, $limit=null, $where);

        
        //query in temporary user table (users waiting for activation)
        //checks if the request comes from add or edit actions
        //query in main user table (users already activated)
	     $this->load->model('FreakAuth_light/UserTemp');
	     $fields='id';
		 $where = array('email'=>$value);
         $query_temp = $this->UserTemp->getUserTemp($fields, $limit=null, $where);

		
        if (($query != null) && ($query->num_rows() > 0))
	    {
	        $this->validation->set_message('_email_duplicate_check', 'A user with this e-mail has already registered.');
		    
	        $query->free_result();
	        return false;
		}
		
		 if (($query_temp != null) && ($query_temp->num_rows() > 0))
	    {
	        $this->validation->set_message('_email_duplicate_check', 'A user with this e-mail has already registered and is waiting for activation. If this is your e-mail address please check your e-mail inbox and activate your ');
		    
	        $query_temp->free_result();
	        return false;
		}
		
		
		//return true;
	}
	
	// --------------------------------------------------------------------
	
    /**
     * RULES HELPER FUNCTION
     * Checks if a country has been chosen in the select country form element
     *
     * @access private
     * @param varchar $value
     * @return boolean
     */
    function _country_check($country_id)
	{
	    if ($this->config->item('FAL_use_country'))
	    {
    	    if ($country_id == 0)
    	    {
    	        $this->validation->country_id= $country_id;
    	    	$this->validation->set_message('_country_check', 'Please specify a country');
    		    return FALSE;
    		}
    	}
		
		return true;
	}
	
	// --------------------------------------------------------------------
	
    /**
     * RULES HELPER FUNCTION
     * Determines if a input text has valid characters and meets min/max length requirements
     *
     * @access private
     * @param unknown_type $callback
     * @param varchar $value
     * @param integer $min
     * @param integer $max
     * @param varchar $invalid_message
     * @param unknown_type $expression
     * @return boolean
     */
    function _is_valid_text($callback, $value, $min, $max, $invalid_message = null, $expression = '/^([a-z0-9])([a-z0-9_\-])*$/ix')
	{
	    $message = '';
	    if ((strlen($value) < $min) ||
	        (strlen($value) > $max))
	        $message .= sprintf($this->lang->line('FAL_lenght_validation_message'), $min, $max);
	        
	    if (!preg_match($expression, $value))
	        $message .= $this->lang->line('FAL_allowed_characters_validation_message');
		
		if ($message != '')
		{
		    if (!isset($invalid_message))
		        $invalid_message = $this->lang->line('FAL_invalid_validation_message');
		    $this->validation->set_message($callback, $invalid_message.$message);
	        return false;
		}
		
		return true;
	}
}

?>