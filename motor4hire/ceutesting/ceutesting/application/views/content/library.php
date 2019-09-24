<?php $this->load->view('template/header'); ?> 
<h2>Library</h2>
<h3>Testing documents</h3>
<p>All documents listed below are in Microsoft Word or Adobe Acrobat format.</p>
<ul>
	<li><?= anchor('library/prolastin_infusion_checklist', 'Prolastin-C Liquid Infusion Checklist') ?></li>
	<li><?= anchor('library/care_plan', 'Care Plan') ?></li>
	<li><?= anchor('library/therapy_guidelines', 'Therapy Guidelines') ?></li>
	<li><?= anchor('library/post_test', 'Post Test') ?></li>
	<li><?= anchor('library/post_test_answer_sheet', 'Post Test Answer Sheet') ?></li>
	<li><?= anchor('library/test_evaluation', 'Test Evaluation') ?></li>
    <?php
    //2017.08.15 jgray: only show the Certificate link if the user is logged in
    //change the anchor to point to the correct certificate generation page
    if (isValidUser()) { ?>
    <li><?= anchor('dashboard/extendedcertificate/'.$this->user_id, 'Certificate') ?></li>
    <?php } ?>
</ul>
<h3>Correspondence documents</h3>
<ul>
	<li><?= anchor('library/fax_cover_sheet', 'Fax Cover Sheet') ?></li>
</ul>
<?php $this->load->view('template/footer'); ?> 
