<?php if (!defined('BASEPATH')) exit('No direct script access allowed');
/**
 * Use it to add functions to the FAL_validation.php class
 * or to overwrite its methods
 *
 */
class MyFALVal extends FAL_validation 
{
    // --------------------------------------------------------------------
    /**
     * class constructor
     *
     * @return MyFALVal
     */
    function MyFALVal()
    {
    	parent::FAL_validation();
		$this->message = '';
    }
    
    // -------------------------------------------------------------------- 
    /**
     * If the user is affiliated with an Agency, make sure Agency Affiliation isrequired.
     */
    function agency_facility_check()
	{
		if (isset($_POST['agency']) AND $_POST['agency'] == 'yes' AND strlen($_POST['agency_affiliation']) == 0)
		{
			$this->message = 'Agency/Facility Affiliation is required.';
			$this->set_message('agency_facility_check', $this->message);
			return FALSE;
		} else {
			return TRUE;
		}
		
    }

    // -------------------------------------------------------------------- 
    /**
     * If the user is affiliated with an Agency, make sure Agency Address is required
     */
    function agency_address_check()
	{
		if (isset($_POST['agency']) AND $_POST['agency'] == 'yes' AND strlen($_POST['agency_address']) == 0)
		{
			$this->message .= 'Agency Address is required.';
			$this->set_message('agency_address_check', $this->message);
			return FALSE;
		} else {
			return TRUE;
		}
		
    }

	// -------------------------------------------------------------------- 
    /**
     * If the user is affiliated with an Agency, make sure Agency City is required
     */
    function agency_city_check()
	{
		if (isset($_POST['agency']) AND $_POST['agency'] == 'yes' AND strlen($_POST['agency_city']) == 0)
		{
			$this->message .= 'Agency City is required.';
			$this->set_message('agency_city_check', $this->message);
			return FALSE;
		} else {
			return TRUE;
		}
		
    }

	// -------------------------------------------------------------------- 
    /**
     * If the user is affiliated with an Agency, make sure Agency Zip is required
     */
    function agency_zip_check()
	{
		if (isset($_POST['agency']) AND $_POST['agency'] == 'yes' AND strlen($_POST['agency_zip']) == 0)
		{
			$this->message .= 'Agency Zip is required.';
			$this->set_message('agency_zip_check', $this->message);
			return FALSE;
		} else {
			return TRUE;
		}
		
    }

	// -------------------------------------------------------------------- 
    /**
     * If the user is affiliated with an Agency, make sure Agency Phone is required
     */
    function agency_phone_check()
	{
		if (isset($_POST['agency']) AND $_POST['agency'] == 'yes' AND strlen($_POST['agency_phone']) == 0)
		{
			$this->message .= 'Agency Phone is required.';
			$this->set_message('agency_phone_check', $this->message);
			return FALSE;
		} else {
			return TRUE;
		}
		
    }
	
}