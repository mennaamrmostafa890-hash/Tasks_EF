using WinFormsApp3.Models;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        ItiContext db = new ItiContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var textfirst = textFN.Text;
            var textLast = textLN.Text;
            var textaddr = textAddr.Text;
            var obj = new Student() { StFname = textfirst, StLname = textLast, StAddress = textaddr };
            db.Students.Add(obj);
            db.SaveChanges();
            LoadStudents();
            textFN.Text = textLN.Text = textAddr.Text = "";
        }
        private void LoadStudents()
        {
            var res = db.Students.Select(s => new
            {
                s.StId,
                s.StFname,
                s.StLname,
                s.StAddress
            }).ToList();

            DGV.DataSource = res;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textFN.Text = textLN.Text = textAddr.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null) // لو فيه صف متحدد
            {
                int id = (int)DGV.CurrentRow.Cells["StId"].Value;

                var student = db.Students.FirstOrDefault(s => s.StId == id);

                if (student != null)
                {
                    student.StFname = textFN.Text;
                    student.StLname = textLN.Text;
                    student.StAddress = textAddr.Text;

                    db.SaveChanges();
                    LoadStudents(); // تحديث الجدول
                    MessageBox.Show("Student updated successfully!");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(DGV.CurrentRow!= null)
            {
                int id = (int)DGV.CurrentRow.Cells["StId"].Value;
                var student = db.Students.FirstOrDefault(s=>s.StId == id);
                if (student != null)
                {
                    db.Students.Remove(student);
                }
                db.SaveChanges();
                LoadStudents();
            }
        }
    }

}
