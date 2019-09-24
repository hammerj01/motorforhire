<ul id="nav">
	<li id="nav_home"><?=anchor('', 'Home')?></li>
	<li id="nav_dashboard"><?=anchor('dashboard', 'Dashboard')?></li>
		<li id="nav_about"><?=anchor('about', 'About')?></li>
	<li id="nav_library"><?=anchor('library', 'Library')?></li>
	<li id="nav_contact"><?=anchor('contact', 'Contact')?></li>
	<li id="nav_logout"><?=anchor($this->config->item('FAL_logout_uri'), 'Logout')?></li>
</ul>