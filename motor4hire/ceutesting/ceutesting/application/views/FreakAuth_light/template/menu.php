	<?php $ci_uri = trim($this->uri->uri_string(), '/'); $att = ' id="active"';?>
    <ul id="navlist">
		<li<?= substr($ci_uri, 0, 5) == 'admin'? $att: ''?>><?=anchor('admin', 'Dashboard')?></li>
	</ul>

