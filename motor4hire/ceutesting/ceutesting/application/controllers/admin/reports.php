<?php

class Reports extends Controller {

	function Reports()
	{
		parent::Controller();
		
		////////////////////////////
		//CHECKING FOR PERMISSIONS
		///////////////////////////
		//-------------------------------------------------
        //only 'admin' and 'superadmin' can view the reports
        
        $this->freakauth_light->check('admin');
        
        //-------------------------------------------------
        //END CHECKING FOR PERMISSION

		//Set template pages and views
        $this->_page = $this->config->item('FAL_template_dir').'template_admin/reports_container';
		$this->_report_nav = $this->config->item('FAL_template_dir').'template_admin/reports_nav';
		$this->_search = $this->config->item('FAL_template_dir').'template_admin/reports_search_form';
		
		//set table formatting
		$this->tmpl = array ('table_open' => '<table>');
		
		//Set validation parameters
		$this->load->library('validation');
		$this->validation->set_error_delimiters('<li>', '</li>');
		
		$rules['name'] = "required";
		$this->validation->set_rules($rules);
		$fields['name'] = 'Name';
		$this->validation->set_fields($fields);	

	}
	
	function index()
	{
		$data['page_class'] = 'onecolumn dashboard';
		$this->load->view($this->_page_all, $data);
	}
	
	function all()
	{	
		$this->heading = 'All Users &raquo; Reports';
		
		$data['page_class'] = 'onecolumn dashboard';
		$data['report_name'] = 'All Users';
		
		// load pagination class
	    $this->load->library('pagination');
	    $config['base_url'] = base_url().'index.php/dashboard/reports/all';
	    $config['total_rows'] = $this->db->count_all('prolastin');
	    $config['per_page'] = '25';
		$config['uri_segment'] = 4;
	    $config['full_tag_open'] = '<ul class="pagination">';
	    $config['full_tag_close'] = '</ul>';
		$config['next_tag_open'] = '<li class="next">';
		$config['next_link'] = 'Next &raquo;';
		$config['next_tag_close'] = '</li>';
		$config['prev_tag_open'] = '<li class="previous">';
		$config['prev_link'] = '&laquo; Previous';
		$config['prev_tag_close'] = '</li>';
		$config['num_tag_open'] = '<li>';
		$config['num_tag_close'] = '</li>';
		$config['cur_tag_open'] = '<li>';
		$config['cur_tag_close'] = '</li>';

	    $this->pagination->initialize($config);
		
	    //load the model and get results
	    $this->load->model('prolastin');
	    $data['results'] = $this->prolastin->get_all($config['per_page'],$this->uri->segment(4));
	
	    // load the HTML Table Class
	    $this->load->library('table');
		$this->table->set_template($this->tmpl);
	    //$this->table->set_heading('Name', 'Pass/Fail Date', 'Pass, Fail, In Progress');
        $this->table->set_heading('Name', 'License#', 'State', 'Agency/Affiliation','Activity ID', 'Pass/Fail Date','Status','Cert Type','Expiration Date');

        // load the view
	    $data['total_rows'] = $config['total_rows'];
		$this->load->view($this->_page, $data);

	}

	//2017.08.17 jgray: export to csv
    function exportall()
    {
        //load the model and get results
        $this->load->model('prolastin');
        $data['results'] = $this->prolastin->get_all(100000,0,1); //optional 3rd param to indicate export as csv for formatting first field

        header("Content-type: application/csv");
        header("Content-Disposition: attachment; filename=prolastin-all.csv");
        header("Pragma: no-cache");
        header("Expires: 0");

        $header = ['Name','License#','State','Agency/Affiliation','Activity ID','Pass/Fail Date','Status','Cert Type','Expiration Date'];
        $fp = fopen('php://output', 'w');
        fputcsv($fp,$header);
        foreach ( $data['results'] as $line ) {
            fputcsv($fp, $line);
            //fseek($fp, -1, SEEK_CUR);
            //fwrite($fp, "\r\n");
        }
        //fputcsv($out, array('this','is some', 'csv "stuff", you know.'));
        fclose($fp);

        // load the view
        //$data['total_rows'] = $config['total_rows'];
        //$this->load->view($this->_page, $data);

    }
	function pass()
	{	
		$this->heading = 'Passed &raquo; Reports';
		
		$data['report_name'] = 'Passed';
		$data['page_class'] = 'onecolumn dashboard';
		
		// load pagination class
	    $this->load->library('pagination');
	    $config['base_url'] = base_url().'index.php/dashboard/reports/pass';
	    $config['per_page'] = '25';
	    $config['per_page'] = '25';
		$config['uri_segment'] = 4;
	    $config['full_tag_open'] = '<ul class="pagination">';
	    $config['full_tag_close'] = '</ul>';
		$config['next_tag_open'] = '<li class="next">';
		$config['next_link'] = 'Next &raquo;';
		$config['next_tag_close'] = '</li>';
		$config['prev_tag_open'] = '<li class="previous">';
		$config['prev_link'] = '&laquo; Previous';
		$config['prev_tag_close'] = '</li>';
		$config['num_tag_open'] = '<li>';
		$config['num_tag_close'] = '</li>';
		$config['cur_tag_open'] = '<li>';
		$config['cur_tag_close'] = '</li>';
		
	    //load the model and get results
	    $this->load->model('prolastin');
	    $data['results'] = $this->prolastin->get_pass($config['per_page'],0);
		
		//get the total number of results returned from the database and set the pagination configuration
		
		$config['total_rows'] = $this->prolastin->total_rows;
		$this->pagination->initialize($config);
		
	    // load the HTML Table Class
	    $this->load->library('table');
		$this->table->set_template($this->tmpl);
	    $this->table->set_heading('Name', 'Pass Date');
	
	    // load the view
		$data['total_rows'] = $config['total_rows'];
		$this->load->view($this->_page, $data);
	}
	
	function fail()
	{	
		$this->heading = 'Failed &raquo; Reports';
		$data['report_name'] = 'Failed';
		$data['page_class'] = 'onecolumn dashboard';
		
		// load pagination class
	    $this->load->library('pagination');
	    $config['base_url'] = base_url().'index.php/dashboard/reports/fail';
	    $config['per_page'] = '25';
	    $config['per_page'] = '25';
		$config['uri_segment'] = 4;
	    $config['full_tag_open'] = '<ul class="pagination">';
	    $config['full_tag_close'] = '</ul>';
		$config['next_tag_open'] = '<li class="next">';
		$config['next_link'] = 'Next &raquo;';
		$config['next_tag_close'] = '</li>';
		$config['prev_tag_open'] = '<li class="previous">';
		$config['prev_link'] = '&laquo; Previous';
		$config['prev_tag_close'] = '</li>';
		$config['num_tag_open'] = '<li>';
		$config['num_tag_close'] = '</li>';
		$config['cur_tag_open'] = '<li>';
		$config['cur_tag_close'] = '</li>';

	    //load the model and get results
	    $this->load->model('prolastin');
	    $data['results'] = $this->prolastin->get_fail($config['per_page'],0);
		
		//get the total number of results returned from the database and set the pagination configuration
		$config['total_rows'] = $this->prolastin->total_rows;
		$this->pagination->initialize($config);
		
	    // load the HTML Table Class
	    $this->load->library('table');
		$this->table->set_template($this->tmpl);
	    $this->table->set_heading('Name', 'Fail Date');
	
	    // load the view
		$data['total_rows'] = $config['total_rows'];
		$this->load->view($this->_page, $data);
	}
	
	function progress()
	{	
		
		$this->heading = 'In Progress &raquo; Reports';
		
		$data['report_name'] = 'In Progress';
		$data['page_class'] = 'onecolumn dashboard';
		
		// load pagination class
	    $this->load->library('pagination');
	    $config['base_url'] = base_url().'index.php/dashboard/reports/progress';
	    $config['per_page'] = '25';
	    $config['per_page'] = '25';
		$config['uri_segment'] = 4;
	    $config['full_tag_open'] = '<ul class="pagination">';
	    $config['full_tag_close'] = '</ul>';
		$config['next_tag_open'] = '<li class="next">';
		$config['next_link'] = 'Next &raquo;';
		$config['next_tag_close'] = '</li>';
		$config['prev_tag_open'] = '<li class="previous">';
		$config['prev_link'] = '&laquo; Previous';
		$config['prev_tag_close'] = '</li>';
		$config['num_tag_open'] = '<li>';
		$config['num_tag_close'] = '</li>';
		$config['cur_tag_open'] = '<li>';
		$config['cur_tag_close'] = '</li>';
		
	    //load the model and get results
	    $this->load->model('prolastin');
	    $data['results'] = $this->prolastin->get_progress($config['per_page'],0);
		
		//get the total number of results returned from the database and set the pagination configuration
		$config['total_rows'] = $this->prolastin->total_rows;
		$this->pagination->initialize($config);
		
	    // load the HTML Table Class
	    $this->load->library('table');
		$this->table->set_template($this->tmpl);
	    $this->table->set_heading('Name', 'Progress');
	
	    // load the view
		$data['total_rows'] = $config['total_rows'];
		$this->load->view($this->_page, $data);
	}
	
	
	
	function search()
	{	
		$this->heading = 'Search Results &raquo; Reports';
		
		$data['report_name'] = 'Search';
		$data['page_class'] = 'onecolumn dashboard';
		
		if ($this->validation->run() == FALSE)
		{
			//echo  'NOT valid';
		} else {
			// load pagination class
	    	$this->load->library('pagination');
	    	$config['base_url'] = base_url().'index.php/dashboard/reports/search';
	    	$config['per_page'] = '25';
		    $config['per_page'] = '25';
			$config['uri_segment'] = 4;
		    $config['full_tag_open'] = '<ul class="pagination">';
		    $config['full_tag_close'] = '</ul>';
			$config['next_tag_open'] = '<li class="next">';
			$config['next_link'] = 'Next &raquo;';
			$config['next_tag_close'] = '</li>';
			$config['prev_tag_open'] = '<li class="previous">';
			$config['prev_link'] = '&laquo; Previous';
			$config['prev_tag_close'] = '</li>';
			$config['num_tag_open'] = '<li>';
			$config['num_tag_close'] = '</li>';
			$config['cur_tag_open'] = '<li>';
			$config['cur_tag_close'] = '</li>';
			
			//load the model and get results
	    	$this->load->model('prolastin');
		    $data['results'] = $this->prolastin->search($config['per_page'],0, $this->input->post('name'));
	
			//get the total number of results returned from the database and set the pagination configuration
			$config['total_rows'] = $this->prolastin->total_rows;
			$this->pagination->initialize($config);
	
		    // load the HTML Table Class
		    $this->load->library('table');
			$this->table->set_template($this->tmpl);
		    $this->table->set_heading('Name', 'Pass/Fail Date', 'Pass, Fail, In Progress');
	
			$data['total_rows'] = $config['total_rows'];
		}
	
	    // load the view
		$this->load->view($this->_page, $data);
	}
	
}
?>