<h3>Step 3 of 4</h3>
<h2>Alpha-1 Antitrypsin Deficiency and Augmentation Therapy-Prolastin</h2>		

<?php if ($this->validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>

<?php echo form_open('dashboard/prolastin/page_three/');?>
	<dl class="one_column">
	<dt></dt>
	<dd><span class="notice">Test progress is saved at the end of each step so you can take the test at your own pace.</span></dd>
	<dd class="clear"><hr /></dd>
	<dt><label for="single_select">21. Universal Precautions and strict aseptic technique are to be instituted:</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q1" id="q1_1" value="a" class="radio" tabindex="1" <?php if ($answer01 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'a'); } ?> /> 
			<label for="q1_1">Only during IV catheter placement.</label></li> 
			<li><input type="radio" name="q1" id="q1_2" value="b" class="radio" tabindex="2" <?php if ($answer01 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'b'); } ?> />
			<label for="q1_2">During reconstitution of the drug.</label></li>
			<li><input type="radio" name="q1" id="q1_3" value="c" class="radio" tabindex="3" <?php if ($answer01 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'c'); } ?> />
			<label for="q1_3">During pooling of the drug.</label></li>
			<li><input type="radio" name="q1" id="q1_4" value="d" class="radio" tabindex="4" <?php if ($answer01 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'd'); } ?> />
			<label for="q1_4">During all drug preparation and administration activities.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">22. Patients receiving augmentation therapy with Prolastin-C can expect that with every infusion, the same number of vials will be reconstituted to achieve their prescribed dose.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q2" id="q2_1" value="a" class="radio" tabindex="5" <?php if ($answer02 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'a'); } ?> /> 
			<label for="q2_1">True.</label></li> 
			<li><input type="radio" name="q2" id="q2_2" value="b" class="radio" tabindex="6" <?php if ($answer02 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'b'); } ?> /> 
			<label for="q2_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">23. Filter needles used in the preparation of Prolastin-C are intended to be used in one direction only.  They should be used either to withdraw reconstituted Prolastin-C from the vial or to transfer Prolastin-C into the pooling bag. Filter needles should never be used for both functions when preparing an individual infusion.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q3" id="q3_1" value="a" class="radio" tabindex="9" <?php if ($answer03 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'a'); } ?> />  
			<label for="q3_1">True.</label></li> 
			<li><input type="radio" name="q3" id="q3_2" value="b" class="radio" tabindex="10" <?php if ($answer03 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'b'); } ?> />
			<label for="q3_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">24. Prolastin-C is produced in what size?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q4" id="q4_1" value="a" class="radio" tabindex="13" <?php if ($answer04 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'a'); } ?> /> 
			<label for="q4_1">5000 mg vial with 100 ml vial of sterile saline diluent.</label></li> 
			<li><input type="radio" name="q4" id="q4_2" value="b" class="radio" tabindex="14" <?php if ($answer04 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'b'); } ?> />
			<label for="q4_2">1000 mg vial with 20 ml vial of sterile water diluent.</label></li>
			<li><input type="radio" name="q4" id="q4_3" value="c" class="radio" tabindex="15" <?php if ($answer04 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'c'); } ?> /> 
			<label for="q4_3">500 mg vial with 20 ml vial of sterile water diluent.</label></li> 
			<li><input type="radio" name="q4" id="q4_4" value="d" class="radio" tabindex="16" <?php if ($answer04 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'd'); } ?> />
			<label for="q4_4">B and C.</label></li>
			<li><input type="radio" name="q4" id="q4_5" value="e" class="radio" tabindex="17" <?php if ($answer04 == "e") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'e'); } ?> />
			<label for="q4_5">A and B.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">25. In general, a weekly infusion takes approximately 2-3 hours to infuse.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q5" id="q5_1" value="a" class="radio" tabindex="17" <?php if ($answer05 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'a'); } ?> /> 
			<label for="q5_1">True.</label></li> 
			<li><input type="radio" name="q5" id="q5_2" value="b" class="radio" tabindex="18" <?php if ($answer05 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'b'); } ?> />
			<label for="q5_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">26. Indicate the correct infusion rate of Prolastin-C for a patient weighing 210 lbs., receiving a weekly dose of 60mg/kg and the IV tubing drop factor = 10gtts/ml.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q6" id="q6_1" value="a" class="radio" tabindex="21" <?php if ($answer06 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'a'); } ?> /> 
			<label for="q6_1">5700 mgs.</label></li> 
			<li><input type="radio" name="q6" id="q6_2" value="b" class="radio" tabindex="22" <?php if ($answer06 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'b'); } ?> />
			<label for="q6_2">1260 mgs.</label></li>
			<li><input type="radio" name="q6" id="q6_3" value="c" class="radio" tabindex="23" <?php if ($answer06 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'c'); } ?> /> 
			<label for="q6_3">335 ml/hr.</label></li> 
			<li><input type="radio" name="q6" id="q6_4" value="d" class="radio" tabindex="24" <?php if ($answer06 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'd'); } ?> />
			<label for="q6_4">456 ml/hr.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">27. Known side effects of Prolastin-C include, but are not limited to:</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q7" id="q7_1" value="a" class="radio" tabindex="25" <?php if ($answer07 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'a'); } ?> /> 
			<label for="q7_1">Sun sensitivity, psoriasis and renal failure.</label></li> 
			<li><input type="radio" name="q7" id="q7_2" value="b" class="radio" tabindex="26" <?php if ($answer07 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'b'); } ?> />
			<label for="q7_2">Nausea, vomiting and bloody diarrhea.</label></li>
			<li><input type="radio" name="q7" id="q7_3" value="c" class="radio" tabindex="27" <?php if ($answer07 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'c'); } ?> />
			<label for="q7_3">Transient elevation of WBC's, delayed fever, malaise and fatigue.</label></li>
			<li><input type="radio" name="q7" id="q7_4" value="d" class="radio" tabindex="28" <?php if ($answer07 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'd'); } ?> />
			<label for="q7_4">Cough, hoarseness and increased sputum production.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">28. Augmentation therapy is self-limiting. Once the patient's symptoms improve, therapy is discontinued.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q8" id="q8_1" value="a" class="radio" tabindex="29" <?php if ($answer08 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'a'); } ?> /> 
			<label for="q8_1">True.</label></li> 
			<li><input type="radio" name="q8" id="q8_2" value="b" class="radio" tabindex="30" <?php if ($answer08 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'b'); } ?> />
			<label for="q8_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">29. Prolastin-C was the first FDA approved therapy specifically for the treatment of severe Alpha-1 Antitrypsin Deficiency and has been available since 1987.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q9" id="q9_1" value="a" class="radio" tabindex="33" <?php if ($answer09 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'a'); } ?> /> 
			<label for="q9_1">True.</label></li> 
			<li><input type="radio" name="q9" id="q9_2" value="b" class="radio" tabindex="34" <?php if ($answer09 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'b'); } ?> />
			<label for="q9_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">30. The goal of augmentation therapy with Prolastin-C is to:</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q10" id="q10_1" value="a" class="radio" tabindex="37" <?php if ($answer10 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'a'); } ?> /> 
			<label for="q10_1">Restore the circulating level of alpha-1 protein toward normal.</label></li> 
			<li><input type="radio" name="q10" id="q10_2" value="b" class="radio" tabindex="38" <?php if ($answer10 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'b'); } ?> />
			<label for="q10_2">Normalize LFT's.</label></li>
			<li><input type="radio" name="q10" id="q10_3" value="c" class="radio" tabindex="39" <?php if ($answer10 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'c'); } ?> />
			<label for="q10_3">Restore lung function.</label></li>
			<li><input type="radio" name="q10" id="q10_4" value="d" class="radio" tabindex="40" <?php if ($answer10 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'd'); } ?> />
			<label for="q10_4">Raise serum levels of trypsin.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dd class="submit"><input type="image" src="/public/shared/images/button-next.jpg" alt="Next Step" name="next_step" id="next_step" value="next_step" tabindex="41" /></dd>
	</dl>
</form>