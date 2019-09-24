<?php

class Certificate extends Controller {

	function Certificate()
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
        $this->_page = $this->config->item('FAL_template_dir').'template_admin/certificate_container';
		
		//Get User id
		$this->user_id = getUserProperty('id');
		
		if(isAdmin()) 
		{
			$this->user_id = $this->uri->segment(3);
		}
	}
	
	function index()
	{
		$this->heading = 'Certificate';
		$data = $this->get_certificate_info(); 
		$data['page_class'] = 'certificate onecolumn';
		$this->load->view($this->_page, $data);
	}


    function get_certificate_info()
    {
        $data['status'] = '';
        $data['complete_date'] = '';
        $data['expiration_date'] = '';

        //get the user status to make sure they can view the certificate
        //2017.08.15 jgray: retrieve complete_date field
        $this->db->select('status, complete_date');
        $this->db->where('user_id', $this->user_id);
        $query = $this->db->get('prolastin');

        foreach ($query->result() as $row)
        {
            $data['status'] = $row->status;
            $data['complete_date'] = $row->complete_date;
        }

        //create a date to display on the certificate
        //$data['date'] = date('m/d/Y');
        //2017.08.15 jgray: create an expiration date 3 years from the complete_date
        $complete_date = $data['complete_date'];
        $expiration_date = new DateTime($complete_date);
        date_add($expiration_date, date_interval_create_from_date_string('3 years'));
        $data['expiration_date'] = date_format($expiration_date, 'm-d-Y');
        $data['complete_date'] = date_format(new DateTime($complete_date),'m-d-Y');

        //get the name to display on the certificate
        $this->db->select('first_name, last_name');
        $this->db->where('id', $this->user_id);
        $query = $this->db->get('fa_user');

        foreach ($query->result() as $row)
        {
            $data['name'] = $row->first_name . ' ' . $row->last_name;
        }
        return $data;

    }
    /* 2017.08.15 jgray: old version
    function get_certificate_info()
	{	
		$data['status'] = '';
		
		//get the user status to make sure they can view the certificate
		$this->db->select('status');
		$this->db->where('user_id', $this->user_id);
		$query = $this->db->get('prolastin');

		foreach ($query->result() as $row)
		{
			$data['status'] = $row->status;
		}
		
		//create a date to display on the certificate
		$data['date'] = date('m/d/Y');
		
		//get the name to display on the certificate
		$this->db->select('first_name, last_name');
		$this->db->where('id', $this->user_id);
		$query = $this->db->get('fa_user');

		foreach ($query->result() as $row)
		{
			$data['name'] = $row->first_name . ' ' . $row->last_name;
		}
		return $data;

	}
	*/
}
?>