<?php  if (!defined('BASEPATH')) exit('No direct script access allowed');
/**
 * Helper for displaying the state dropdown
 * 
 * @author      Joey Marchy
 * @link 		http://www.ngenworks.com
 */
// ------------------------------------------------------------------------
//
// Returns the state dropdown list with the appropriate form name and selected field.
// $which - which name the form field should have
// $selected_state - state is selected, if any
//
function getState($which)
{
	//initialize select variables
	$state_drop_down = '';
	$state_options = '';
	$selected = '';
	$selected_state = '';
	$open_select = '<select name="'.$which.'" id="'.$which.'" class="small">';
	$close_select = '</select>';
	$options = array("Alabama"=>"AL", "Alaska"=>"AK", "Arizona"=>"AZ", "Arkansas"=>"AR", "California"=>"CA", "Colorado"=>"CO", "Connecticut"=>"CT", "Delaware"=>"DE", "D.C."=>"DC", "Florida"=>"FL", "Georgia"=>"GA", "Hawaii"=>"HI", "Idaho"=>"ID", "Illinois"=>"IL", "Indiana"=>"IN", "Iowa"=>"IA", "Kansas"=>"KS", "Kentucky"=>"KY", "Louisiana"=>"LA", "Maine"=>"ME", "Maryland"=>"MD", "Massachusetts"=>"MA", "Michigan"=>"MI", "Minnesota"=>"MN", "Mississippi"=>"MS", "Missouri"=>"MO", "Montana"=>"MT", "Nebraska"=>"NE", "Nevada"=>"NV", "New Hampshire"=>"NH", "New Mexico"=>"NM", "New Jersey"=>"NJ", "New York"=>"NY", "North Carolina"=>"NC", "North Dakota"=>"ND", "Ohio"=>"OH", "Oklahoma"=>"OK", "Oregon"=>"OR", "Pennsylvania"=>"PA", "Rhode Island"=>"RI", "South Carolina"=>"SC", "South Dakota"=>"SD", "Tennessee"=>"TN", "Texas"=>"TX", "Utah"=>"UT", "Vermont"=>"VT", "Virginia"=>"VA", "Washington"=>"WA", "West Virginia"=>"WV", "Wisconsin"=>"WI", "Wyoming"=>"WY"); 
	
	if (isset($_POST[$which]))
	{
		$selected_state = $_POST[$which];
	}
	
	foreach ($options as $key => $value) {
		if ($selected_state == $key)
		{
			$selected = 'selected="selected"';
		} else {
			$selected = '';
		}
		
		$state_options .= '<option value="' . $key . '" ' . $selected . '>' . $value . '</option>';
	}
	
	$state_drop_down .= $open_select;
	$state_drop_down .= $state_options;
	$state_drop_down .= $close_select;
		
	return $state_drop_down;
}

function getStateEdit($which, $selected_state)
{
	//initialize select variables
	$state_drop_down = '';
	$state_options = '';
	$selected = '';
	$open_select = '<select name="'.$which.'" id="'.$which.'" class="small">';
	$close_select = '</select>';
	$options = array("Alabama"=>"AL", "Alaska"=>"AK", "Arizona"=>"AZ", "Arkansas"=>"AR", "California"=>"CA", "Colorado"=>"CO", "Connecticut"=>"CT", "Delaware"=>"DE", "D.C."=>"DC", "Florida"=>"FL", "Georgia"=>"GA", "Hawaii"=>"HI", "Idaho"=>"ID", "Illinois"=>"IL", "Indiana"=>"IN", "Iowa"=>"IA", "Kansas"=>"KS", "Kentucky"=>"KY", "Louisiana"=>"LA", "Maine"=>"ME", "Maryland"=>"MD", "Massachusetts"=>"MA", "Michigan"=>"MI", "Minnesota"=>"MN", "Mississippi"=>"MS", "Missouri"=>"MO", "Montana"=>"MT", "Nebraska"=>"NE", "Nevada"=>"NV", "New Hampshire"=>"NH", "New Mexico"=>"NM", "New Jersey"=>"NJ", "New York"=>"NY", "North Carolina"=>"NC", "North Dakota"=>"ND", "Ohio"=>"OH", "Oklahoma"=>"OK", "Oregon"=>"OR", "Pennsylvania"=>"PA", "Rhode Island"=>"RI", "South Carolina"=>"SC", "South Dakota"=>"SD", "Tennessee"=>"TN", "Texas"=>"TX", "Utah"=>"UT", "Vermont"=>"VT", "Virginia"=>"VA", "Washington"=>"WA", "West Virginia"=>"WV", "Wisconsin"=>"WI", "Wyoming"=>"WY"); 
		
	foreach ($options as $key => $value) {
		if ($selected_state == $key)
		{
			$selected = 'selected="selected"';
		} else {
			$selected = '';
		}
		
		$state_options .= '<option value="' . $key . '" ' . $selected . '>' . $value . '</option>';
	}
	
	$state_drop_down .= $open_select;
	$state_drop_down .= $state_options;
	$state_drop_down .= $close_select;
		
	return $state_drop_down;
}

?>