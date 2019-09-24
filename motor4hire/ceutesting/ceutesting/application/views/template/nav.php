<ul id="nav">
	<li id="nav_home"><?=anchor('', 'Home')?></li>
	<?php if (isValidUser()) { ?>
	<li id="nav_dashboard"><?=anchor('dashboard', 'Dashboard')?></li>
	<?php } ?>
	<li id="nav_about"><?=anchor('about', 'About')?></li>
	<?php if (!isValidUser()) { ?>
	<li id="nav_register"><?=anchor($this->config->item('FAL_register_uri'), 'Register')?></li>
	<?php } ?>
	<li id="nav_library"><?=anchor('library', 'Library')?></li>
	<li id="nav_contact"><?=anchor('contact', 'Contact')?></li>
	<?php if (isValidUser()) { ?>
	<li id="nav_logout"><?=anchor($this->config->item('FAL_logout_uri'), 'Logout')?></li>
	<?php } else { ?>
	<li id="nav_login"><?=anchor($this->config->item('FAL_login_uri'), 'Login')?></li>
	<?php } ?>	
</ul>