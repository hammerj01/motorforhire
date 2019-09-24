<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Myaccount</title>
</head>
<body>
<h1>Userprofile for user <?=$user['user_name']?></h1>
<p><?=anchor('myaccount/edit/'.$user['id'], 'EDIT')?></p>
<ul>
<li>username: <?=$user['user_name']?></li>
<li>e-mail: <?=$user['email']?></li>
<?php if ($this->config->item('FAL_use_country') && isset($user['country']))
	        {?>
	    		<li>country: <?=$user['country'];?></li>
	    	<?php 
	        }?>
<?php if ($this->config->item('FAL_create_user_profile') AND !empty($user_profile))
{?>
	
	<?php 
		foreach ($user_profile as $field=>$profile)
		{?>
			<li><?=$label[$field]?>: <?=$profile?></li>
		
		<?php 
		}?>
	
<?php 
}
elseif($this->config->item('FAL_create_user_profile') AND empty($user_profile)) 
{?>
	 <p class="error">no data in DB: please add them</p>
<?php 
} else {?><p class="error">userprofile disabled in config</p><?php }?>
</ul>

</body>
</html>