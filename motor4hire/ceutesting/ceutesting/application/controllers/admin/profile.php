<?php

class Profile extends Controller {

	function Profile()
	{
		parent::Controller();
		
		////////////////////////////
		//CHECKING FOR PERMISSIONS
		///////////////////////////
		//-------------------------------------------------
        //only 'users', 'admin' and 'superadmin' can take the test
        
        $this->freakauth_light->check('user');
        
        //-------------------------------------------------
        //END CHECKING FOR PERMISSION

		//Set template pages and views
        $this->_page = $this->config->item('FAL_template_dir').'template_admin/profile_container';
		
		//If user make sure they can only see their profile
		if (isAdmin()){
		 	$this->user_id = $this->uri->segment(3);
		} else {
			$this->user_id = getUserProperty('id');
		}
		
		//Set validation parameters
		$this->load->library('validation');
		$this->validation->set_error_delimiters('<li>', '</li>');
	}
	
	function index()
	{
		//Load state helper
		$this->load->helper('state');
		$this->heading = 'Profile';
		$confirmation_message = '';
		
		//Set validation parameters
		$rules['first_name'] = 'trim|required|xss_clean';
		$rules['last_name'] = 'trim|required|xss_clean';
		$rules['address'] = 'trim|required|xss_clean';
		$rules['city'] = 'trim|required|xss_clean';
		$rules['zip'] = 'trim|required|xss_clean';
		$rules['phone'] = 'trim|required|xss_clean';
		$rules['agency'] = 'trim|required|xss_clean';
		$rules['agency_affiliation'] = 'trim|xss_clean|callback_agency_affiliation_check';
		$rules['agency_address'] = 'trim|xss_clean|callback_agency_address_check';
		$rules['agency_city'] = 'trim|xss_clean|callback_agency_city_check';
		$rules['agency_zip'] = 'trim|xss_clean|callback_agency_zip_check';
		$rules['agency_phone'] = 'trim|xss_clean|callback_agency_phone_check';
		$rules['agency_state_number'] = 'trim|required|xss_clean';
		$this->validation->set_rules($rules);
		
		$fields['first_name'] = 'First Name';
		$fields['last_name'] = 'Last Name';
		$fields['address'] = 'Address';
		$fields['city'] = 'City';
		$fields['zip'] = 'State';
		$fields['phone'] = 'Zip';
		$fields['agency_state_number'] = 'License Number';
		$fields['agency'] = 'Agency';
		$fields['agency_affiliation'] = 'Agency/Facility Affiliation';
		$fields['agency_address'] = 'Agency Address';
		$fields['agency_city'] = 'Agency City';
		$fields['agency_zip'] = 'Agency Zip';
		$fields['agency_phone'] = 'Agency Phone';
		$this->validation->set_fields($fields);	
		$data['page_class'] = 'profile onecolumn';
		
		//Load data array with sidebar data
		$test_data = $this->get_test_score();
		$data['score'] = $test_data['score'];
		$data['status'] = $test_data['status'];
		$pass_fail_progress = $this->pass_fail_progress($data['status'], $data['score']);
		$data['pass_fail_progress'] = $pass_fail_progress;
		
		if ($this->validation->run() == FALSE)
		{
			
			//Check to see if we need to initialize the post data or get data from the database
			if (isset($_POST['redisplay']) AND $_POST['redisplay'] == 'true')
			{
				$data['first_name'] = $this->input->post('first_name');
				$data['last_name'] = $this->input->post('last_name');
				$data['address'] = $this->input->post('address');
				$data['city'] = $this->input->post('city');
				$data['state'] = $this->input->post('state');
				$data['zip'] = $this->input->post('zip');
				$data['phone'] = $this->input->post('phone');
				$data['agency'] = $this->input->post('agency');
				$data['agency_affiliation'] = $this->input->post('agency_affiliation');
				$data['agency_address'] = $this->input->post('agency_address');
				$data['agency_city'] = $this->input->post('agency_city');
				$data['agency_state'] = $this->input->post('agency_state');
				$data['agency_zip'] = $this->input->post('agency_zip');
				$data['agency_phone'] = $this->input->post('agency_phone');
				$data['agency_license_state'] = $this->input->post('agency_license_state');
				$data['agency_state_number'] = $this->input->post('agency_state_number');
				$data['more_agencies'] = $this->input->post('more_agencies');
			} else {	
				//Get user data fields
				$query = $this->usermodel->getUserById($this->user_id);
				if ($query->num_rows()>0)
				{ 
				 	$i=1;
				 	foreach ($query->result() as $row)
					{
						$data['first_name'] = $row->first_name;
						$data['last_name'] = $row->last_name;
						$data['address'] = $row->address;
						$data['city'] = $row->city;
						$data['state'] = $row->state;
						$data['zip'] = $row->zip;
						$data['phone'] = $row->phone;
						$data['agency'] = $row->agency;
						$data['agency_affiliation'] = $row->agency_affiliation;
						$data['agency_address'] = $row->agency_address;
						$data['agency_city'] = $row->agency_city;
						$data['agency_state'] = $row->agency_state;
						$data['agency_zip'] = $row->agency_zip;
						$data['agency_phone'] = $row->agency_phone;
						$data['agency_license_state'] = $row->agency_license_state;
						$data['agency_state_number'] = $row->agency_state_number;
						$data['more_agencies'] = $row->more_agencies;
					}
				}
			}
			$this->load->view($this->_page, $data);
		} else {
			$user_data = array(
				'first_name' => $this->input->post('first_name'),
				'last_name' => $this->input->post('last_name'),
				'address' => $this->input->post('address'),
				'city' => $this->input->post('city'),
				'state' => $this->input->post('state'),
				'zip' => $this->input->post('zip'),
				'phone' => $this->input->post('phone'),
				'agency' => $this->input->post('agency'),
				'agency_affiliation' => $this->input->post('agency_affiliation'),
				'agency_address' => $this->input->post('agency_address'),
				'agency_city' => $this->input->post('agency_city'),
				'agency_state' => $this->input->post('agency_state'),
				'agency_zip' => $this->input->post('agency_zip'),
				'agency_phone' => $this->input->post('agency_phone'),
				'agency_license_state' => $this->input->post('agency_license_state'),
				'agency_state_number' => $this->input->post('agency_state_number'),
				'more_agencies' => $this->input->post('more_agencies')
				);
			//If validation passes, update user
			$this->db->where('id', $this->user_id);
			$this->db->update('fa_user', $user_data);
			$user_data['score'] = $test_data['score'];
			$user_data['status'] = $test_data['status'];
			$user_data['pass_fail_progress'] = $pass_fail_progress;
			$user_data['confirmation_message'] = 'Profile Updated';
			$user_data['page_class'] = 'profile onecolumn';
			$this->load->view($this->_page, $user_data);
		}
	}
	
	//Get the users test score from the database
	function get_test_score()
	{
		//get the user status to make sure they can view the certificate
		$this->db->select('score, status');
		$this->db->where('user_id', $this->user_id);
		$query = $this->db->get('prolastin');

		if ($query->num_rows() > 0) 
		{
			foreach ($query->result() as $row)
			{
				$data['score'] = $row->score;
				$data['status'] = $row->status;
			}
			return $data;
		} else {
			$data['score'] = 0;
			$data['status'] = "";
			return $data;
		}
	}
	
	//Based on the score return if they Pass, Fail or are In Progress
	function pass_fail_progress($status, $score)
	{
		if ($status == "") {
			return anchor('dashboard/prolastin', 'Take the test');
		} elseif ($status == 'fail') {
			return 'Fail';
		} elseif ($status == 'pass' OR $status == 'complete') {
			return 'Pass';
		} else {
			return 'In Progress';
		}
	}
	
	
	function agency_affiliation_check($str)
	{
		if ($_POST['agency'] == 'yes' AND strlen($_POST['agency_affiliation']) == 0)
		{
			$this->validation->set_message('agency_affiliation_check', 'Agency/Facility Affiliation is required.');
			return FALSE;
		}
		else
		{
			return TRUE;
		}
	}
	
	function agency_address_check($str)
	{
		if ($_POST['agency'] == 'yes' AND strlen($_POST['agency_address']) == 0)
		{
			$this->validation->set_message('agency_address_check', 'Agency Address is required.');
			return FALSE;
		}
		else
		{
			return TRUE;
		}
	}
	
	function agency_city_check($str)
	{
		if ($_POST['agency'] == 'yes' AND strlen($_POST['agency_city']) == 0)
		{
			$this->validation->set_message('agency_city_check', 'Agency City is required.');
			return FALSE;
		}
		else
		{
			return TRUE;
		}
	}
	
	function agency_zip_check($str)
	{
		if ($_POST['agency'] == 'yes' AND strlen($_POST['agency_zip']) == 0)
		{
			$this->validation->set_message('agency_zip_check', 'Agency Zip is required.');
			return FALSE;
		}
		else
		{
			return TRUE;
		}
	}
	
	function agency_phone_check($str)
	{
		if ($_POST['agency'] == 'yes' AND strlen($_POST['agency_phone']) == 0)
		{
			$this->validation->set_message('agency_phone_check', 'Agency Phone is required.');
			return FALSE;
		}
		else
		{
			return TRUE;
		}
	}
	
}
?>