<?php
/**
 * Class evaluation
 */


class EvaluationModel extends Model 
{
	
	// ------------------------------------------------------------------------
	/**
	 * initialises the class inheriting the methods of the class Model 
	 *
	 * @return Evaluation
	 */
    function EvaluationModel()
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
	function get_all($id) 
	{
    	$data['num_rows'] = '0';
		$this->db->select('fa_user.first_name, fa_user.last_name, evaluation.date, evaluation.q1, evaluation.q2, 
						   evaluation.q3, evaluation.q4, evaluation.q5, evaluation.q6, evaluation.q7, evaluation.q8,
						   evaluation.q9, evaluation.q10, evaluation.q11, evaluation.q12, evaluation.q13, evaluation.q14,
						   evaluation.q15');
		$this->db->from('fa_user, evaluation');
		$this->db->where('fa_user.id = evaluation.user_id AND evaluation.user_id = '.$id);

		$query = $this->db->get();
		
		if ($query->num_rows() > 0)
		{
			foreach ($query->result() as $row)
		   	{
		      	$data['first_name'] = $row->first_name;
				$data['last_name'] = $row->last_name;
				$data['date'] = $row->date;
				$data['q1'] = $row->q1;
				$data['q2'] = $row->q2;
				$data['q3'] = $row->q3;
				$data['q4'] = $row->q4;
				$data['q5'] = $row->q5;
				$data['q6'] = $row->q6;
				$data['q7'] = $row->q7;
				$data['q8'] = $row->q8;
				$data['q9'] = $row->q9;
				$data['q10'] = $row->q10;
				$data['q11'] = $row->q11;
				$data['q12'] = $row->q12;
				$data['q13'] = $row->q13;
				$data['q14'] = $row->q14;
				$data['q15'] = $row->q15;
		   	}
			$data['num_rows'] = $query->num_rows();
			return $data;
		} else {
			$data['num_rows'] = $query->num_rows();
			return $data;
		}
  	}
}
?>