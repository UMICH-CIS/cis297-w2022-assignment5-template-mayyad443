using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTable
{
public partial class DisplayAuthorsTable : Form
{

public DisplayAuthorsTable()
{
DisplayAuthorsTable();
} 


private BooksDataContext database = new BooksDataContext();


private void DisplayAuthorsTable_Load( object sender, EventArgs e )
{

authorBindingSource.DataSource =
from author in database.Authors
orderby author.AuthorID
select author;
} 


private void authorBindingNavigatorSaveItem_Click(
object sender, EventArgs e )
{
Validate(); 
authorBindingSource.EndEdit(); 
database.SubmitChanges(); 
} 

private void findButton_Click( object sender, EventArgs e )
{

authorBindingSource.DataSource =
from author in database.Authors
where author.LastName.StartsWith( findTextBox.Text )
orderby author.AuthorID
select author;
} 
} 

} 


