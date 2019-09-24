<?php
/**
 * Class prolastin
 */


class Prolastin extends Model 
{
	
	// ------------------------------------------------------------------------
	/**
	 * initialises the class inheriting the methods of the class Model 
	 *
	 * @return Prolastin
	 */
    function Prolastin()
    {     
        parent::Model();
    }
	
     // ------------------------------------------------------------------------
    
    /**
     * Retrieves all records from the prolastin table
     * 
     * @param string of fields wanted $fields
     * @param array $limit
     * @param string $where
     * @return query string
     */
	function get_all($num, $offset, $csv = 0)
	{

    	//$this->db->select('fa_user.id, fa_user.first_name, fa_user.last_name, fa_user.agency_state_number, fa_user.agency_license_state, fa_user.agency_affiliation, prolastin.complete_date, prolastin.status, fa_user');
        //$this->db->limit($num, $offset);
        if($offset == ''){$offset = 0;}
        $query = $this->db->query('SELECT fau.id, fau.first_name, fau.last_name, fau.agency_state_number, fau.agency_license_state, fau.agency_affiliation, p.complete_date, p.status, c.certificate_number, c.certificate_number_type, c.expires FROM fa_user fau INNER JOIN prolastin p ON p.user_id = fau.id LEFT JOIN certificate c ON c.id = p.certificate_id LIMIT '.$offset.','.$num);
        //$data['pass'] = $query->num_rows();
        if ($query->num_rows()>0) {
            $data = array();
            $i = 0;
            foreach ($query->result() as $row) {
                $data[$i] = array(
                    $csv == 0 ? $this->name_link($row->id, $row->first_name, $row->last_name) : $row->last_name.", ".$row->first_name,
                    $row->agency_state_number,
                    $row->agency_license_state,
                    $row->agency_affiliation,
                    $row->certificate_number,
                    $this->formatDate($row->complete_date),
                    $this->test_status($row->status),
                    $row->certificate_number_type,
                    $row->expires);
                $i++;
            }
            return $data;
        }

/*
		$this->db->from('fa_user, prolastin, certificate');
		$this->db->where('fa_user.id = prolastin.user_id AND prolastin.certificate_id = certificate.id');
		$this->db->limit($num, $offset);
		$query = $this->db->get();
		
		if ($query->num_rows() > 0)
		{
		   	$data = array();
			$i = 0;
			foreach ($query->result() as $row)
		   	{
		      	$data[$i] = array($this->name_link($row->id, $row->first_name, $row->last_name),
                    $row->agency_state_number,
								  $this->formatDate($row->complete_date), 
								  $this->test_status($row->status),
                                  );
				$i++;
		   	}
			return $data;
		}
*/
  	}

	
	function search($num, $offset, $name) 
	{		
		if (strlen($name) == 1) {
			$this->db->where('fa_user.id = prolastin.user_id AND fa_user.last_name LIKE "'.$name.'%"');
		} else {
			$this->db->where('fa_user.id = prolastin.user_id AND fa_user.last_name LIKE "%'.$name.'%"');
		}
		
				
		$this->db->select('fa_user.id, fa_user.first_name, fa_user.last_name, prolastin.complete_date, prolastin.status');
		$this->db->from('fa_user, prolastin');
		$this->db->limit($num, $offset);
		$query = $this->db->get();
		
		$this->total_rows = $query->num_rows();
		
		if ($query->num_rows() > 0)
		{
		   	$data = array();
			$i = 0;
			foreach ($query->result() as $row)
		   	{
		      	$data[$i] = array($this->name_link($row->id, $row->first_name, $row->last_name), 
								  $this->formatDate($row->complete_date), 
								  $this->test_status($row->status));
				$i++;
		   	}
			return $data;
		}
  	}


	
	function get_pass($num, $offset) 
	{
    	$this->db->select('fa_user.id, fa_user.first_name, fa_user.last_name, prolastin.complete_date');
		$this->db->from('fa_user, prolastin');
		$this->db->where('fa_user.id = prolastin.user_id AND prolastin.status = "pass" OR fa_user.id = prolastin.user_id
AND prolastin.status = "complete"');
		$this->db->limit($num, $offset);
		$query = $this->db->get();
		
		//this number is used in the pagination configuration
		$this->total_rows = $query->num_rows();
		
		if ($query->num_rows() > 0)
		{
		   	$data = array();
			$i = 0;
			foreach ($query->result() as $row)
		   	{
		      	$data[$i] = array($this->name_link($row->id, $row->first_name, $row->last_name),
								  $this->formatDate($row->complete_date));
				$i++;
		   	}
			return $data;
		}
  	}




	function get_fail($num, $offset) 
	{
    	$this->db->select('fa_user.id, fa_user.first_name, fa_user.last_name, prolastin.complete_date');
		$this->db->from('fa_user, prolastin');
		$this->db->where('fa_user.id = prolastin.user_id AND prolastin.status = "fail"');
		$this->db->limit($num, $offset);
		$query = $this->db->get();
		
		//this number is used in the pagination configuration
		$this->total_rows = $query->num_rows();
		
		if ($query->num_rows() > 0)
		{
		   	$data = array();
			$i = 0;
			foreach ($query->result() as $row)
		   	{
		      	$data[$i] = array($this->name_link($row->id, $row->first_name, $row->last_name),
								  $this->formatDate($row->complete_date));
				$i++;
		   	}
			return $data;
		}
  	}


	
	function get_progress($num, $offset) 
	{
		$this->db->select('fa_user.id, fa_user.first_name, fa_user.last_name, prolastin.status');
		$this->db->from('fa_user, prolastin');
		$this->db->where('fa_user.id = prolastin.user_id AND prolastin.status LIKE "page%"');
		$this->db->limit($num, $offset);
		$query = $this->db->get();
		
		//this number is used in the pagination configuration
		$this->total_rows = $query->num_rows();
		
		if ($query->num_rows() > 0)
		{
		   	$data = array();
			$i = 0;
			foreach ($query->result() as $row)
		   	{
		      	$data[$i] = array($this->name_link($row->id, $row->first_name, $row->last_name),
								  $this->test_status($row->status));
				$i++;
		   	}
			return $data;
		}
  	}


	////////////////////////////////////////////////////////////////
	//HELPER FUNCTIONS FOR THE MODEL
	////////////////////////////////////////////////////////////////
	
	//Writes proper test status to send back to the controller
	function test_status($status)
	{
		switch ($status)
		{
			case 'pass':
			case 'complete':	
				return 'Pass';
				break;
			case 'fail':	
				return 'Fail';
				break;
			case 'page_one':	
				return 'Currently on page 1';
				break;
			case 'page_two':	
				return 'Currently on page 2';
				break;
			case 'page_three':	
				return 'Currently on page 3';
				break;
			case 'page_four':	
				return 'Currently on page 4';
				break;
			default:	
				return 'In Progress';
				break;
		}
	}
	
	//Writes link for username test status to send back to the controller
	function name_link($id, $first_name, $last_name)
	{
		$name = $last_name . ", " . $first_name;
		return anchor('dashboard/profile/'.$id, $name);
	}
	
	//formatDate($date)
	//takes a date in the form of 2006-03-30 and reformats it to 03-30-2006
	function formatDate($date){
		if ($date == '0000-00-00')
		{
			return '';
		}
		
		$date_array = explode("-", $date);
		$date = $date_array[1].'-'.$date_array[2].'-'.$date_array[0];
		return $date;
	}

}
?>