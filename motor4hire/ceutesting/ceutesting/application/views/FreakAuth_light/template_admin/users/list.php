<h2><?=$action?></h2>

<?=$pagination_links;?>

<?php
//if no records in DB don't display the result table
if (isset($user)) 
  {?>
<?php echo anchor('dashboard/'.$controller.'/add', $controller=='admins' ? 'Add admin user' : 'Add user'); ?>
<table>
  <tr>
    <th scope="col">Edit</th>
    <th scope="col">Username</th>
    <th scope="col">Role</th>
	<th scope="col">Delete</th>
  </tr>

  <?php foreach($user as $key=>$value):?>
  <tr class="center">
	<td>
        <?php
        if ($user[$key]['show_edit_link'])
            echo anchor('dashboard/'.$controller.'/edit/'.$user[$key]['id'], '<img src="'.base_url().$this->config->item('FAL_assets_admin').'/'.$this->config->item('FAL_images').'/pencil.png" alt="edit" title="edit">', array('title' => 'edit'));
        ?>
    </td>
    <td><?=$user[$key]['user_name'];?></td>
    <td><?=$user[$key]['role']?></td>
	<td>
        <?php
		if ($user[$key]['show_delete_link'])
            echo anchor('dashboard/'.$controller.'/del/'.$user[$key]['id'], '<img src="'.base_url().$this->config->item('FAL_assets_admin').'/'.$this->config->item('FAL_images').'/cross.png" alt="delete" title="delete">', array('onCLick' => "return confirm('".$this->lang->line('FAL_confirm_delete')."')", 'title' => 'delete'));
        ?>
    </td>
  </tr>
  <?php endforeach;?>
</table>
<?php }?>

<?=$pagination_links;?>