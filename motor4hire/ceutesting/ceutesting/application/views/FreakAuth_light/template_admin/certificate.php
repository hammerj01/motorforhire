<style>
    .certificate-logo{
        width: 10%;
        float: left;
    }
</style>
<h2 id="section_head">Alpha-1 Nurse Certification of Completion</h2>

<?php if ($status == "complete") { ?>	

<div id="certificate">
<h2>Alpha-1 Nurse Certification of Completion</h2>
<h1><?php echo $name; ?></h1>
<p class="intro">Has Successfully Completed Alpha-1 Antitrypsin Deficiency and Augmentation Therapy - Prolastin-C Liquid</p>
<p><strong>Date:</strong> <u><?php echo $complete_date; ?></u></p>
<p><strong>Expiration Date of Activity:</strong>  <u>02-09-2019<?php //echo $expiration_date; ?></u></p>
<p><strong>For:</strong> <u>3.0</u> <strong>Contact Hours</strong></p>


<p><strong>Presented By:</strong> AlphaNet, Inc.<br />3300 Ponce de Leon Boulevard<br />Coral Gables, FL  33134
<div id="certificate_director"><img src="/public/shared/images/signature-robert.gif" alt="Signature of Robert Sandhaus MD, PH.D" class="signature" /><br />Robert Sandhaus MD, PH.D<br />Medical Director</div>
<div id="alphanetlogo"><img src="/public/shared/images/alphanet-vertical-logo.jpg" alt="Alphanet Alphas serving alphas" class="certificate-logo"/></div>
<div id="certificate_coordinator"><img src="/public/shared/images/signature-teresa.gif" alt="Teresa Kitchen RN, BSN" class="signature" /><br />Teresa Kitchen RN, BSN<br />Educational Program Coordinator</div>
<p class="foot">This continuing nursing educational activity was approved by the Washington State Nurses Association Approver of Continuing Nursing Education, an accredited approver by the American Nurses Credentialing Center’s Commission on Accreditation.</p>
</div> <!-- close #certificate -->
</div> <!-- close #content -->

<?php } elseif ($status == "fail") { ?>

<div class="message">
<ul>
<li>You have not passed the test yet. Please <?php echo anchor('dashboard/prolastin/take_test_again', 'retake and pass the test to receive your certificate') ?>.</li>
</ul>	
</div> <!-- .message -->

<?php } else { ?>

<div class="message">
<ul>
<li>You must pass the test before receiving your certificate. Please <?php echo anchor('dashboard/prolastin', 'finish the test') ?>.</li>
</ul>	
</div> <!-- .message -->
	
<?php } ?>
