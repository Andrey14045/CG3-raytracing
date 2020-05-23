﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.IO;
using System.Windows.Forms;

namespace CG3_raytracing
{
    public partial class Form1 : Form
    {
        View view;
        bool loaded = false;
        public Form1()
        {
            InitializeComponent();
            view = new View();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            view.Setup(glControl1.Width, glControl1.Height);
            view.initShaders();
            view.DrawQuad();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                view.ReDraw();
                glControl1.SwapBuffers();
                GL.UseProgram(0);
            }
        }
    }
}
