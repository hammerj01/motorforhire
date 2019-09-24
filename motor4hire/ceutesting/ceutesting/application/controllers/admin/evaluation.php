<?php

class Evaluation extends Controller {

	function Evaluation()
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
        $this->_page = $this->config->item('FAL_template_dir').'template_admin/evaluation_container';
		$this->_view_page = $this->config->item('FAL_template_dir').'template_admin/evaluation_view_container';
		
		//Get User id
		$this->user_id = getUserProperty('id');	
		
		//Set validation parameters
		$this->load->library('validation');
		$this->validation->set_error_delimiters('<li>', '</li>');
	}
	
	function index()
	{
		$this->heading = 'Evaluation';
		
		$data['page_class'] = 'onecolumn';
		$data['status'] = $this->get_status();
		
		//Set validation parameters
		$rules['q1'] = "required";
		$rules['q2'] = "required";
		$rules['q3'] = "required";
		$rules['q4'] = "required";
		$rules['q5'] = "required";
		$rules['q6'] = "required";
		$rules['q7'] = "required";
		$rules['q8'] = "required";
		$rules['q9'] = "required";
		$rules['q10'] = "required";
		$rules['q11'] = "required";
		$rules['q12'] = "required";
		$rules['q13'] = "required";
		$rules['q14'] = "callback_q14_check";
		
		$this->validation->set_rules($rules);
		
		$fields['q1'] = 'Question 1';
		$fields['q2'] = 'Question 2';
		$fields['q3'] = 'Question 3';
		$fields['q4'] = 'Question 4';
		$fields['q5'] = 'Question 5';
		$fields['q6'] = 'Question 6';
		$fields['q7'] = 'Question 7';
		$fields['q8'] = 'Question 8';
		$fields['q9'] = 'Question 9';
		$fields['q10'] = 'Question 10';
		$fields['q11'] = 'Question 11';
		$fields['q12'] = 'Question 12';
		$fields['q13'] = 'Question 13';
		$fields['q14'] = 'Question 14';

		$this->validation->set_fields($fields);
		
		if ($this->validation->run() == FALSE)
		{
			$this->load->view($this->_page, $data);
		} else {
			//If in progress we need to update the table
			$evaluation_data = array(
					'user_id' => $this->user_id,
					'q1' => $this->input->post('q1'),
					'q2' => $this->input->post('q2'),
					'q3' => $this->input->post('q3'),
					'q4' => $this->input->post('q4'),
					'q5' => $this->input->post('q5'),
					'q6' => $this->input->post('q6'),
					'q7' => $this->input->post('q7'),
					'q8' => $this->input->post('q8'),
					'q9' => $this->input->post('q9'),
					'q10' => $this->input->post('q10'),
					'q11' => $this->input->post('q11'),
					'q12' => $this->input->post('q12'),
					'q13' => $this->input->post('q13'),
					'q14' => $this->input->post('q14'),
					'q15' => $this->input->post('q15'));

			//Insert a new record
			$this->db->insert('evaluation', $evaluation_data); 
			$this->update_status();
			//Go to page two of the test
			redirect('/dashboard/');
		}
	}
	
	
	function q14_check($str)
	{
		if ($this->input->post('q13') == 'no' AND strlen($str) == '0')
		{
			$this->validation->set_message('q14_check', 'Please tell us why you think this program had commercial bias.');
			return FALSE;
		}
		else
		{
			return TRUE;
		}
	}
	
	
	function view()
	{
		$this->heading = 'View Evaluation';
		//load the model and get results
	    $this->load->model('evaluationmodel');
	    $data = $this->evaluationmodel->get_all($this->uri->segment(4));
		$data['page_class'] = 'onecolumn';
		
		$this->load->view($this->_view_page, $data);
	}

    //2017.08.17 jgray: retrieve the current certificate id based on program and date
    function get_certificate_id(){
        $id = 0;
        $query = $this->db->query("SELECT c.id FROM certificate c WHERE Now() BETWEEN c.start_date AND c.end_date AND c.certificate_type = 'prolastin'");
        if ($query->num_rows() == 1)
        {
            //$row = $query->result();
            $row = $query->row();
            $id = $row->id;
        }
        return $id;
    }

    function update_status()
    {
        $certificate_id = $this->get_certificate_id();
        $data = array('status' => 'complete', 'certificate_id' => $certificate_id);
        $this->db->where('user_id', $this->user_id);
        $this->db->update('prolastin', $data);
    }

/*
    function update_status()
	{	
		$data = array('status' => 'complete');
		$this->db->where('user_id', $this->user_id);
		$this->db->update('prolastin', $data);
	}
	
*/
	function get_status()
	{	
		$this->db->select('status');
		$this->db->from('prolastin');
		$this->db->where('user_id', $this->user_id);
		$query = $this->db->get();

		if ($query->num_rows() > 0)
		{
			foreach ($query->result() as $row)
   			{
      			$data['status'] = $row->status;
				return $data['status'];
   			}
		} else {
			return $data['status'] = "";
		}
	}
	
}
?>