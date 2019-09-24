<?php $this->load->view('template/header'); ?> 

<h2>Contact Us</h2>
<p>For further information about AlphaNet Continuing Nursing Education programs, to request a DVD copy of Alpha-1 Antitrypsin Deficiency and Augmentation Therapy (Prolastin-C Liquid) and/or to send required course materials to obtain Contact Hours:</p>

<h3>Contact</h3>
<p>Teresa Kitchen BSN, RN<br />
Clinical Nurse Manager<br />
AlphaNet, Inc.<br />
<strong>Phone:</strong> 888-553-0093<br />
<strong>Fax:</strong> 618-551-2699 <?= anchor('library/fax_cover_sheet', 'download the fax cover sheet') ?><br />
<strong>Email:</strong> <?php echo safe_mailto('tkitchen@alphanet.org', 'Teresa Kitchen'); ?></p>
<p class="callout">To contact AlphaNet, Inc. or other AlphaNet personnel return to the AlphaNet homepage <a href="http://www.alphanet.org">www.alphanet.org</a> and click on  <a href="http://www.alphanet.org/contact">Contact Us</a></p>

<?php $this->load->view('template/footer'); ?> 
