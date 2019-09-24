<?php

class Prolastin extends Controller {

	function Prolastin()
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
        $this->_page1 = $this->config->item('FAL_template_dir').'template_admin/prolastin';
		$this->_page2 = $this->config->item('FAL_template_dir').'template_admin/prolastin2';
		$this->_page3 = $this->config->item('FAL_template_dir').'template_admin/prolastin3';
		$this->_page4 = $this->config->item('FAL_template_dir').'template_admin/prolastin4';
		
		//Get User id
		$this->user_id = getUserProperty('id');	

		//Set validation parameters
		$this->load->library('validation');
		$this->validation->set_error_delimiters('<li>', '</li>');
		
		//Check to see if test is in progress
		$this->in_progress = $this->test_in_progress();
	}
	
	function index()
	{	
		$this->heading = 'Page 1 &raquo; Prolastin Test';
		switch ($this->in_progress) 
		{
			case 'page_one':
				redirect('dashboard/prolastin/page_two');
				break;
			case 'page_two':
				redirect('dashboard/prolastin/page_three');
				break;
			case 'page_three':
				redirect('dashboard/prolastin/page_four');
				break;
		}
		
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
		$this->validation->set_fields($fields);	
	
		if ($this->validation->run() == FALSE)
		{
			if ($this->in_progress){
				
				//get data for form
				$a = $this->get_answers();
				
				$data = array(
               	'answer01' => $a['answer01'],
               	'answer02' => $a['answer02'],
               	'answer03' => $a['answer03'],
				'answer04' => $a['answer04'],
				'answer05' => $a['answer05'],
				'answer06' => $a['answer06'],
				'answer07' => $a['answer07'],
				'answer08' => $a['answer08'],
				'answer09' => $a['answer09'],
				'answer10' => $a['answer10']);	
			} else {
				$data['answer01'] = '';
				$data['answer02'] = '';
				$data['answer03'] = '';
				$data['answer04'] = '';
				$data['answer05'] = '';
				$data['answer06'] = '';
				$data['answer07'] = '';
				$data['answer08'] = '';
				$data['answer09'] = '';
				$data['answer10'] = '';
			}
			$data['page_class'] = 'prolastin';
			$this->load->view($this->_page1, $data);
		} else {
			//If in progress we need to update the table
			$test_data = array(
					'user_id' => $this->user_id,
					'answer01' => $this->input->post('q1'),
					'answer02' => $this->input->post('q2'),
					'answer03' => $this->input->post('q3'),
					'answer04' => $this->input->post('q4'),
					'answer05' => $this->input->post('q5'),
					'answer06' => $this->input->post('q6'),
					'answer07' => $this->input->post('q7'),
					'answer08' => $this->input->post('q8'),
					'answer09' => $this->input->post('q9'),
					'answer10' => $this->input->post('q10'),
					'status' => 'page_one');
			if ($this->in_progress) {
				$this->db->where('user_id', $this->user_id);
				$this->db->update('prolastin', $test_data);
			} else {
				//If NOT in progress we need to insert a new record
				$this->db->insert('prolastin', $test_data); 
			}
			
			//Go to page two of the test
			redirect('/dashboard/prolastin/page_two/');
		}
	}
	
	
	
	
	
	//page two of the test
	function page_two()
	{
		$this->heading = 'Page 2 &raquo; Prolastin Test';
		$data['page_class'] = 'prolastin';
		
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
		$this->validation->set_rules($rules);
		
		$fields['q1'] = 'Question 11';
		$fields['q2'] = 'Question 12';
		$fields['q3'] = 'Question 13';
		$fields['q4'] = 'Question 14';
		$fields['q5'] = 'Question 15';
		$fields['q6'] = 'Question 16';
		$fields['q7'] = 'Question 17';
		$fields['q8'] = 'Question 18';
		$fields['q9'] = 'Question 19';
		$fields['q10'] = 'Question 20';
		$this->validation->set_fields($fields);
		
		if ($this->validation->run() == FALSE)
		{
			if ($this->in_progress){
				
				//get data for form
				$a = $this->get_answers();
				
				$this->data = array(
               	'answer01' => $a['answer11'],
               	'answer02' => $a['answer12'],
               	'answer03' => $a['answer13'],
				'answer04' => $a['answer14'],
				'answer05' => $a['answer15'],
				'answer06' => $a['answer16'],
				'answer07' => $a['answer17'],
				'answer08' => $a['answer18'],
				'answer09' => $a['answer19'],
				'answer10' => $a['answer20'],
				'page_class' => 'prolastin'
          		);	
			} else {
				$this->data['answer01'] = '';
				$this->data['answer02'] = '';
				$this->data['answer03'] = '';
				$this->data['answer04'] = '';
				$this->data['answer05'] = '';
				$this->data['answer06'] = '';
				$this->data['answer07'] = '';
				$this->data['answer08'] = '';
				$this->data['answer09'] = '';
				$this->data['answer10'] = '';
			}
			$data['page_class'] = 'prolastin';	
			$this->load->view($this->_page2, $this->data);
		} else {
			//If in progress we need to update the table
			$this->data = array(
					'user_id' => $this->user_id,
					'answer11' => $this->input->post('q1'),
					'answer12' => $this->input->post('q2'),
					'answer13' => $this->input->post('q3'),
					'answer14' => $this->input->post('q4'),
					'answer15' => $this->input->post('q5'),
					'answer16' => $this->input->post('q6'),
					'answer17' => $this->input->post('q7'),
					'answer18' => $this->input->post('q8'),
					'answer19' => $this->input->post('q9'),
					'answer20' => $this->input->post('q10'),
					'status' => 'page_two');
			if ($this->in_progress) {
				$this->db->where('user_id', $this->user_id);
				$this->db->update('prolastin', $this->data);
			} else {
				//If NOT in progress we need to insert a new record
				$data['page_class'] = 'prolastin';
				$this->db->insert('prolastin', $this->data); 
			}
			
			//Go to page three of the test
			redirect('/dashboard/prolastin/page_three/');
		}
	}
	
	
	
	
	
	//page three of the test
	function page_three()
	{
		$this->heading = 'Page 3 &raquo; Prolastin Test';
		$data['page_class'] = 'prolastin';
		
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
		$this->validation->set_rules($rules);
		
		$fields['q1'] = 'Question 21';
		$fields['q2'] = 'Question 22';
		$fields['q3'] = 'Question 23';
		$fields['q4'] = 'Question 24';
		$fields['q5'] = 'Question 25';
		$fields['q6'] = 'Question 26';
		$fields['q7'] = 'Question 27';
		$fields['q8'] = 'Question 28';
		$fields['q9'] = 'Question 29';
		$fields['q10'] = 'Question 30';
		$this->validation->set_fields($fields);
		
		if ($this->validation->run() == FALSE)
		{
			if ($this->in_progress){
				
				//get data for form
				$a = $this->get_answers();
				
				$this->data = array(
               	'answer01' => $a['answer21'],
               	'answer02' => $a['answer22'],
               	'answer03' => $a['answer23'],
				'answer04' => $a['answer24'],
				'answer05' => $a['answer25'],
				'answer06' => $a['answer26'],
				'answer07' => $a['answer27'],
				'answer08' => $a['answer28'],
				'answer09' => $a['answer29'],
				'answer10' => $a['answer30'],
				'page_class' => 'prolastin'
          		);	
			} else {
				$this->data['answer01'] = '';
				$this->data['answer02'] = '';
				$this->data['answer03'] = '';
				$this->data['answer04'] = '';
				$this->data['answer05'] = '';
				$this->data['answer06'] = '';
				$this->data['answer07'] = '';
				$this->data['answer08'] = '';
				$this->data['answer09'] = '';
				$this->data['answer10'] = '';
			}
				
			$this->load->view($this->_page3, $this->data);
		} else {
			//If in progress we need to update the table
			$this->data = array(
					'user_id' => $this->user_id,
					'answer21' => $this->input->post('q1'),
					'answer22' => $this->input->post('q2'),
					'answer23' => $this->input->post('q3'),
					'answer24' => $this->input->post('q4'),
					'answer25' => $this->input->post('q5'),
					'answer26' => $this->input->post('q6'),
					'answer27' => $this->input->post('q7'),
					'answer28' => $this->input->post('q8'),
					'answer29' => $this->input->post('q9'),
					'answer30' => $this->input->post('q10'),
					'status' => 'page_three');
			if ($this->in_progress) {
				$this->db->where('user_id', $this->user_id);
				$this->db->update('prolastin', $this->data);
			} else {
				//If NOT in progress we need to insert a new record
				$data['page_class'] = 'prolastin';
				$this->db->insert('prolastin', $this->data); 
			}
			
			//Go to page four of the test
			redirect('/dashboard/prolastin/page_four/');
		}
	}
	
	
	
	
	
	//page four of the test
	function page_four()
	{
		$this->heading = 'Page 4 &raquo; Prolastin Test';
		$data['page_class'] = 'prolastin';
		
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
		$this->validation->set_rules($rules);
		
		$fields['q1'] = 'Question 31';
		$fields['q2'] = 'Question 32';
		$fields['q3'] = 'Question 33';
		$fields['q4'] = 'Question 34';
		$fields['q5'] = 'Question 35';
		$fields['q6'] = 'Question 36';
		$fields['q7'] = 'Question 37';
		$fields['q8'] = 'Question 38';
		$fields['q9'] = 'Question 39';
		$fields['q10'] = 'Question 40';
		$this->validation->set_fields($fields);
		
		if ($this->validation->run() == FALSE)
		{
			if ($this->in_progress){
				
				//get data for form
				$a = $this->get_answers();
				
				$this->data = array(
               	'answer01' => $a['answer31'],
               	'answer02' => $a['answer32'],
               	'answer03' => $a['answer33'],
				'answer04' => $a['answer34'],
				'answer05' => $a['answer35'],
				'answer06' => $a['answer36'],
				'answer07' => $a['answer37'],
				'answer08' => $a['answer38'],
				'answer09' => $a['answer39'],
				'answer10' => $a['answer40'],
				'page_class' => 'prolastin'
          		);	
			} else {
				$this->data['answer01'] = '';
				$this->data['answer02'] = '';
				$this->data['answer03'] = '';
				$this->data['answer04'] = '';
				$this->data['answer05'] = '';
				$this->data['answer06'] = '';
				$this->data['answer07'] = '';
				$this->data['answer08'] = '';
				$this->data['answer09'] = '';
				$this->data['answer10'] = '';
			}
				
			$this->load->view($this->_page4, $this->data);
		} else {
			//If in progress we need to update the table
			$this->data = array(
					'user_id' => $this->user_id,
					'answer31' => $this->input->post('q1'),
					'answer32' => $this->input->post('q2'),
					'answer33' => $this->input->post('q3'),
					'answer34' => $this->input->post('q4'),
					'answer35' => $this->input->post('q5'),
					'answer36' => $this->input->post('q6'),
					'answer37' => $this->input->post('q7'),
					'answer38' => $this->input->post('q8'),
					'answer39' => $this->input->post('q9'),
					'answer40' => $this->input->post('q10'),
					'status' => 'page_four');
			if ($this->in_progress) {
				$this->db->where('user_id', $this->user_id);
				$this->db->update('prolastin', $this->data);
			} else {
				//If NOT in progress we need to insert a new record
				$data['page_class'] = 'prolastin';
				$this->db->insert('prolastin', $this->data); 
			}
			
			//Score test
			$this->score_test();
		}
	}
	
	
	
	
	
	//score the questions
	function score_test()
	{
		//NEED TO:::::::::::::::::::::::::
		// *change total to 40
		// *add all answers to answer array
		// *write code to put score in database and mark test as pass, fail, etc
		// *redirect to correct page
		
		//TOTAL NUMBER OF QUESTIONS
		$total = 40;
		$number_correct = 0;
		$number_incorrect = 0;
		$percentage = 0;
		$result = "";
		$redirect = "/dashboard/";
		
		//get user answers from the database
		$a = $this->get_answers();
		
		//load the score array with the actual answers
		/*
		$score = array('c', 'a', 'a', 'a', 'd', 'b', 'd', 'a', 'd', 'd',
		 			   'a', 'b', 'd', 'a', 'd', 'd', 'd', 'a', 'b', 'd',
					   'd', 'b', 'a', 'd', 'b', 'd', 'c', 'b', 'a', 'a',
					   'b', 'b', 'b', 'c', 'c', 'a', 'a', 'c', 'd', 'd');
    */
		$score = array('c', 'a', 'a', 'a', 'd', 'b', 'd', 'a', 'd', 'd',
		 			   'a', 'b', 'd', 'a', 'd', 'd', 'd', 'a', 'b', 'd',
					   'd', 'b', 'a', 'b', 'b', 'd', 'c', 'b', 'a', 'a',
					   'b', 'b', 'b', 'c', 'c', 'a', 'a', 'c', 'd', 'd');
		
		//compare the two and calculate the score
		$i = 0;
		foreach ($a as $user_answer) {
			if ($user_answer == $score[$i++]) {
				$number_correct++;
			}			
		}
		
		//Display Number Incorrect
		$number_incorrect = $total - $number_correct;
			
		//Percentage
		$percentage = ($number_correct / $total)*100;
		
		//Pass or Fail?
		if ($percentage < 80) {
			$this->set_status('fail', $percentage);
		} else {
			$this->set_status('pass', $percentage);
		}
		
		redirect($redirect);
		
	}
	
	
		
	//set the test status, pass or fail
	function set_status($status, $score)
	{
		$date = date("Y-m-d"); 
		$this->data = array('status' => $status, 'score' => $score, 'complete_date' => $date);
		$this->db->where('user_id', $this->user_id);
		$this->db->update('prolastin', $this->data);
	}
	
	
	
	//Check to see if this user has started the test or if they are resuming
	function test_in_progress() {
		$sql = "SELECT status FROM prolastin WHERE user_id = ?";
		$query = $this->db->query($sql, array($this->user_id));
			
		if ($query->num_rows() > 0) {
			foreach ($query->result() as $row)
			{
    			return $row->status;
			}
		} else {
			return FALSE;
		}
	}
	
	
	
	//If someone is taking the test again we want to clear their answers
	//Delete the entire row associated with this user.
	function take_test_again() {
		$this->db->delete('prolastin', array('user_id' => $this->user_id)); 
		redirect('/dashboard/prolastin/');
	}
	
	
	
	
	//Get the answers to the test and return the results
	//Accepts a page of answers to return or 'all'
	function get_answers() {
		//answers array
		$a = array();
		
		//get answers and store them in array
		$query = $this->db->getwhere('prolastin', array('user_id' => $this->user_id));
		foreach ($query->result() as $row) {
   			$a['answer01'] = $row->answer01;
			$a['answer02'] = $row->answer02;
			$a['answer03'] = $row->answer03;
			$a['answer04'] = $row->answer04;
			$a['answer05'] = $row->answer05;
			$a['answer06'] = $row->answer06;
			$a['answer07'] = $row->answer07;
			$a['answer08'] = $row->answer08;
			$a['answer09'] = $row->answer09;
			$a['answer10'] = $row->answer10;
			
			//page 2
			$a['answer11'] = $row->answer11;
			$a['answer12'] = $row->answer12;
			$a['answer13'] = $row->answer13;
			$a['answer14'] = $row->answer14;
			$a['answer15'] = $row->answer15;
			$a['answer16'] = $row->answer16;
			$a['answer17'] = $row->answer17;
			$a['answer18'] = $row->answer18;
			$a['answer19'] = $row->answer19;
			$a['answer20'] = $row->answer20;
			
			//page 3
			$a['answer21'] = $row->answer21;
			$a['answer22'] = $row->answer22;
			$a['answer23'] = $row->answer23;
			$a['answer24'] = $row->answer24;
			$a['answer25'] = $row->answer25;
			$a['answer26'] = $row->answer26;
			$a['answer27'] = $row->answer27;
			$a['answer28'] = $row->answer28;
			$a['answer29'] = $row->answer29;
			$a['answer30'] = $row->answer30;
			
			//page 4
			$a['answer31'] = $row->answer31;
			$a['answer32'] = $row->answer32;
			$a['answer33'] = $row->answer33;
			$a['answer34'] = $row->answer34;
			$a['answer35'] = $row->answer35;
			$a['answer36'] = $row->answer36;
			$a['answer37'] = $row->answer37;
			$a['answer38'] = $row->answer38;
			$a['answer39'] = $row->answer39;
			$a['answer40'] = $row->answer40;
		}
		
		return $a;
	}
		
}
?>