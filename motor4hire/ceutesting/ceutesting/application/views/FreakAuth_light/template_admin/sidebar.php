<div id="sidebar">
<?php if (!isAdmin()) { ?>
	
<ul id="nav_sub">
	<li><?php echo anchor('dashboard/profile/'.getUserProperty('id'), 'View/Edit Profile'); ?>
</ul>

<?php } elseif (belongsToGroup('superadmin', true)) { ?>

<ul id="nav_sub">
	<li <?php if ($this->uri->segment(2) == 'admins') { echo 'class="here"'; } ?>><?php echo anchor('dashboard/admins', 'Manage Admin Users') ?>
</ul>

<?php } ?>

</div> <!-- close #sidebar -->