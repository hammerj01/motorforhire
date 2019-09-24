<h2>Evaluation</h2>
		<?php if ($num_rows == 0) { ?>
			<div class="message">
				<p>No evaluation for this user</p>
			</div> <!-- .message -->
		<?php } else { ?>
		<h3><?php echo $first_name. " " . $last_name ?></h3>

		<p>
			Date Completed: <em><?php echo $date ?></em><br />
			AlphaNet, Inc. <em>CEARP # 9231</em>
		</p>
		<div class="callout">
		<p><em>Use the following rating scale to answer the questions below:</em></p>
		<ul id="rating_scale">
			<li><strong>4</strong> = Excellent</li>
			<li><strong>3</strong> = Average</li>
			<li><strong>2</strong> = Fair</li>
			<li><strong>1</strong> = Poor</li>
			<li><strong>N</strong> = Not Applicable</li>
		</ul>

		</div>
		
		<p><strong>To what extent have you achieved each of the objectives below?</strong></p>
				<dl class="two_column">
					<dt><?php echo $q1 ?></dt>
					<dd><label for="q1">Participants will discover that Alpha-1 is genetically transmitted, can lead to liver disease, early onset emphysema, and other conditions.</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q2 ?></dt>
					<dd><label for="q2">Participants will recognize that the disorder has been generally under diagnosed and/or misdiagnosed.</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q3 ?></dt>
					<dd><label for="q3">Participants will list at least three key elements in the treatment plan of individuals with Alpha-1 including augmentation therapy with Prolastin-C.</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q4 ?></dt>
					<dd><label for="q4">Participants will indicate their specific knowledge of the criteria for initiating, dosing, and administering augmentation therapy with Prolastin-C.</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q5 ?></dt>
					<dd><label for="q5">Participants will list at least four potential side effects associated with augmentation therapy with Prolastin-C.</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q6 ?></dt>
					<dd><label for="q6">Each participant shall identify procedures for safe and appropriate handling of Prolastin-C, as well as parameters for patient assessment and monitoring during therapy.</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q7 ?></dt>
					<dd><label for="q7">Participants will name resources available in the community for those affected by Alpha-1 Antitrypsin Deficiency and their health care providers.</label></dd>
					<dd class="clear"><hr /></dd>
				</dl>
				<p><strong>General Questions (Use the scale above)</strong></p>
				<dl class="two_column">
					<dt><?php echo $q8 ?></dt>
					<dd><label for="q8">To what extent did this program demonstrate effective teaching strategies?</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q9 ?></dt>
					<dd><label for="q9">To what extent was the overall  program goal met: To increase  knowledge of Alpha-1 Antitrypsin Deficiency and Augmentation therapy.</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q10 ?></dt>
					<dd><label for="q10">At what level would you rate your knowledge of this subject before viewing this program?</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q11 ?></dt>
					<dd><label for="q11">At what level would you rate your knowledge of this subject after viewing this program?</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><?php echo $q12 ?></dt>
					<dd><label for="q12">How many hours did it take you to complete this activity?</label></dd>
					<dd class="clear"><hr /></dd>
					<dt><label>Was this program free of commercial bias?</label></dt>
					<dd><?php echo $q13 ?></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="q14">If No, explain</label></dt>
					<dd><?php echo $q14 ?></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="q15">Comments for Improvements</label></dt>
					<dd><?php echo $q15 ?></dd>
					<dd class="clear"><hr /></dd>
				</dl>

			</form>
			<?php } ?>