<?php

class PrintCertificate extends Controller {

	function PrintCertificate()
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
        $this->_page = $this->config->item('FAL_template_dir').'template_admin/print_certificate_container';
		
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
		$data = $this->get_extended_certificate_info();
		$data['page_class'] = 'certificate onecolumn';
		$this->load->view($this->_page, $data);
	}

    //2017.08.16 jgray: get data from new certificate table
    function get_extended_certificate_info()
    {
        $data['status'] = '';
        $data['complete_date'] = '';
        $data['expiration_date'] = '';

        //2017.08.16 jgray:
        $query = $this->db->query('SELECT p.status, p.complete_date, c.certificate_number, c.certificate_number_type, c.expires, c.footer_language FROM prolastin p INNER JOIN certificate c ON c.id = p.certificate_id WHERE p.user_id='.$this->user_id);
        $data['pass'] = $query->num_rows();
        if ($query->num_rows()>0) {
            $i = 1;
            foreach ($query->result() as $row) {
                $data['status'] = $row->status;
                $data['complete_date'] = $row->complete_date;
                $data['certificate_number'] = $row->certificate_number;
                $data['certificate_number_type'] = $row->certificate_number_type;
                $data['expiration_date'] = $row->expires;
                $data['footer_language'] = $row->footer_language;
                $i = $i+1;
            }
        }

        //create a date to display on the certificate
        //$data['date'] = date('m/d/Y');
        //2017.08.15 jgray: create an expiration date 3 years from the complete_date
        $complete_date = $data['complete_date'];
        $expiration_date = $data['expiration_date'];//new DateTime($complete_date);
        //date_add($expiration_date, date_interval_create_from_date_string('3 years'));
        $data['complete_date'] = date_format(new DateTime($complete_date),'m-d-Y');
        $data['expiration_date'] = date_format(new DateTime($expiration_date), 'm-d-Y');

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

}
?>