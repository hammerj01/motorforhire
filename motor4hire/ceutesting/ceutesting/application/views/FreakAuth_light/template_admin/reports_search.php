<h2>Reports: <?php echo $report_name; ?></h2>

<?php if ($this->validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>

<?php if (isset($total_rows)) { ?>
	<?php if ($total_rows == 0) { ?>
		<div class="message error">
			<ul><li>No results. Please search again.</li></ul>
		</div> <!-- .message -->
	<?php }  ?>
<?php }  ?>	


<?php $this->load->view($this->_search); ?>
<?php $this->load->view($this->_report_nav); ?>

<?php if (isset($total_rows)) { ?>
	<?php if ($total_rows != 0) { ?>
		<?php echo $this->table->generate($results); ?>
		<?php echo $this->pagination->create_links(); ?>
	<?php }  ?>
<?php }  ?>