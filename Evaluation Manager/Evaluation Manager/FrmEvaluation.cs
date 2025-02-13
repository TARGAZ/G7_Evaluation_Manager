﻿using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmEvaluation : Form
    {
        private Student selectdStudent;

        public FrmEvaluation(Student selectdStudent)
        {
            InitializeComponent();
            this.selectdStudent = selectdStudent;
            this.Text = $"{selectdStudent.FirstName}{selectdStudent.LastName}";
        }

        private void FrmEvaluation_Load(object sender, EventArgs e)
        {
            PopulateActivities();
        }

        private void PopulateActivities()
        {
            cboActivities.DataSource = ActivityRepository.GetActivities();
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity selectedActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = selectedActivity.Description;
            txtMinForGrade.Text = selectedActivity.MinPointsForGrade.ToString();
            txtMinForSignature.Text = selectedActivity.MinPointsForSignature.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO - Save score to the database.
        }
    }
}
