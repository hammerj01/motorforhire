<?php if (!defined('BASEPATH')) exit('No direct script access allowed');
/**
 * Use it to add functions to the Freakauth_light.php class
 * or to overwrite its methods
 *
 */
class MyFAL extends Freakauth_light 
{
    // -------------------------------------------------------------------- 
    /**
     * Class constructor
     * not really needed but I wrote it anyway
     *
     * @return MyFAL
     */
    function MyFAL()
    {
    	parent::Freakauth_light();
    }
    
    // -------------------------------------------------------------------- 
    /**
     * This function replaces the register function in the FAL_front
     *
     */

	function _register()
    {	
		//if users are not allowed to register
        if (!$this->CI->config->item('FAL_allow_user_registration'))
        {
        	redirect('login_check', 'location');
        }
        //if they are allowed to register
        else
        {
			$this->CI->page = 'register';
			
			//sets the necessary form fields
            $fields['user_name'] = $this->CI->lang->line('FAL_user_name_label');
            $fields['password'] = $this->CI->lang->line('FAL_user_password_label');
            $fields['password_confirm'] = $this->CI->lang->line('FAL_user_password_confirm_label');
            $fields['email'] = $this->CI->lang->line('FAL_user_email_label');
			$fields['first_name'] = $this->CI->lang->line('FAL_user_first_name_label');
			$fields['last_name'] = $this->CI->lang->line('FAL_user_last_name_label');
			$fields['address'] = $this->CI->lang->line('FAL_user_address_label');
			$fields['city'] = $this->CI->lang->line('FAL_user_city_label');
			$fields['zip'] = $this->CI->lang->line('FAL_user_zip_label');
			$fields['phone'] = $this->CI->lang->line('FAL_user_phone_label');
			$fields['agency_state_number'] = $this->CI->lang->line('FAL_user_agency_state_number_label');
			$fields['agency'] = $this->CI->lang->line('FAL_user_agency_label');
			$fields['agency_affiliation'] = $this->CI->lang->line('FAL_user_agency_affiliation_label');
			$fields['agency_address'] = $this->CI->lang->line('FAL_user_agency_address_label');
			$fields['agency_city'] = $this->CI->lang->line('FAL_user_agency_city_label');
			$fields['agency_zip'] = $this->CI->lang->line('FAL_user_agency_zip_label');
			$fields['agency_phone'] = $this->CI->lang->line('FAL_user_agency_phone_label');
			$fields['terms_conditions'] = $this->CI->lang->line('FAL_user_terms_conditions_label');
           			
            //set validation rules
            $rules['user_name'] = 'trim|required|xss_clean|username_check|username_duplicate_check';
            $rules['password'] = 'trim|required|xss_clean|password_check';
            $rules['password_confirm'] = 'trim|required|xss_clean|matches[password]';
            $rules['email'] = 'trim|required|valid_email|xss_clean|email_duplicate_check';
			$rules['first_name'] = 'trim|required|xss_clean';
			$rules['last_name'] = 'trim|required|xss_clean';
			$rules['address'] = 'trim|required|xss_clean';
			$rules['city'] = 'trim|required|xss_clean';
			$rules['zip'] = 'trim|required|xss_clean';
			$rules['phone'] = 'trim|required|xss_clean';
			$rules['agency_state_number'] = 'trim|xss_clean|required';
			$rules['agency'] = 'trim|required|xss_clean|agency_facility_check|agency_address_check|agency_city_check|agency_zip_check|agency_phone_check';
			$rules['agency_affiliation'] = 'trim|xss_clean';
			$rules['agency_address'] = 'trim|xss_clean';
			$rules['agency_city'] = 'trim|xss_clean';
			$rules['agency_zip'] = 'trim|xss_clean';
			$rules['agency_phone'] = 'trim|xss_clean';
			$rules['terms_conditions'] = 'trim|required|xss_clean';
              
        //-----------------------------------------------
        //ADD MORE FIELDS AND RULES HERE IF YOU NEED THEM
        //-----------------------------------------------
        
        $this->CI->fal_validation->set_fields($fields);
        $this->CI->fal_validation->set_rules($rules);
       
        //if everything went ok 
        if ($this->CI->fal_validation->run() && $this->CI->freakauth_light->register())
        {
			$data['heading'] = $this->CI->lang->line('FAL_register_label');
			//normal registration with e-mail validation
			if (!$this->CI->config->item('FAL_register_direct'))
			{
			    return $this->CI->load->view($this->CI->config->item('FAL_register_success_view'), $data, TRUE);
			}
			//direct registration
			else
			{
			    redirect($this->CI->config->item('FAL_login_uri'), 'location');
			}
        }
       
        //redisplay the register form
        else
        {
		    //displays the view
	        $data['heading'] = $this->CI->lang->line('FAL_register_label');
			return $this->CI->load->view($this->CI->config->item('FAL_register_view'), $data, TRUE);
	        }
        }
    }
	
}