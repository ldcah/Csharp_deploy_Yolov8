using System.Windows.Forms;

namespace ModelDeployPlatform
{
    partial class FormModelDeployPlat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_model_path = new System.Windows.Forms.TextBox();
            this.btn_choose_model_path = new System.Windows.Forms.Button();
            this.rb_openvino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_opencv = new System.Windows.Forms.RadioButton();
            this.rb_onnx = new System.Windows.Forms.RadioButton();
            this.rb_tensorrt = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_yolov8_cls = new System.Windows.Forms.RadioButton();
            this.rb_yolov8_pose = new System.Windows.Forms.RadioButton();
            this.rb_yolov8_seg = new System.Windows.Forms.RadioButton();
            this.rb_yolov8_det = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_clas_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_test_image = new System.Windows.Forms.TextBox();
            this.btn_choose_claspath = new System.Windows.Forms.Button();
            this.btn_choose_testimage = new System.Windows.Forms.Button();
            this.btn_model_deploy = new System.Windows.Forms.Button();
            this.btn_engine_conv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(34, 397);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 339);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(645, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(645, 397);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(617, 339);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(837, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "图片预测结果展示";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "推理模型:";
            // 
            // tb_model_path
            // 
            this.tb_model_path.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_model_path.Location = new System.Drawing.Point(95, 44);
            this.tb_model_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_model_path.Name = "tb_model_path";
            this.tb_model_path.Size = new System.Drawing.Size(420, 26);
            this.tb_model_path.TabIndex = 4;
            // 
            // btn_choose_model_path
            // 
            this.btn_choose_model_path.Location = new System.Drawing.Point(535, 44);
            this.btn_choose_model_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_choose_model_path.Name = "btn_choose_model_path";
            this.btn_choose_model_path.Size = new System.Drawing.Size(49, 18);
            this.btn_choose_model_path.TabIndex = 5;
            this.btn_choose_model_path.Text = "选 择";
            this.btn_choose_model_path.UseVisualStyleBackColor = true;
            this.btn_choose_model_path.Click += new System.EventHandler(this.btn_choose_model_path_Click);
            // 
            // rb_openvino
            // 
            this.rb_openvino.AutoSize = true;
            this.rb_openvino.Checked = true;
            this.rb_openvino.Location = new System.Drawing.Point(15, 21);
            this.rb_openvino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_openvino.Name = "rb_openvino";
            this.rb_openvino.Size = new System.Drawing.Size(113, 24);
            this.rb_openvino.TabIndex = 6;
            this.rb_openvino.TabStop = true;
            this.rb_openvino.Text = "OpenVINO";
            this.rb_openvino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_opencv);
            this.groupBox1.Controls.Add(this.rb_onnx);
            this.groupBox1.Controls.Add(this.rb_tensorrt);
            this.groupBox1.Controls.Add(this.rb_openvino);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(22, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(507, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "推理设备";
            // 
            // rb_opencv
            // 
            this.rb_opencv.AutoSize = true;
            this.rb_opencv.Location = new System.Drawing.Point(416, 21);
            this.rb_opencv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_opencv.Name = "rb_opencv";
            this.rb_opencv.Size = new System.Drawing.Size(94, 24);
            this.rb_opencv.TabIndex = 6;
            this.rb_opencv.Text = "OpenCV";
            this.rb_opencv.UseVisualStyleBackColor = true;
            // 
            // rb_onnx
            // 
            this.rb_onnx.AutoSize = true;
            this.rb_onnx.Location = new System.Drawing.Point(259, 21);
            this.rb_onnx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_onnx.Name = "rb_onnx";
            this.rb_onnx.Size = new System.Drawing.Size(141, 24);
            this.rb_onnx.TabIndex = 6;
            this.rb_onnx.Text = "ONNX runtime";
            this.rb_onnx.UseVisualStyleBackColor = true;
            // 
            // rb_tensorrt
            // 
            this.rb_tensorrt.AutoSize = true;
            this.rb_tensorrt.Location = new System.Drawing.Point(139, 21);
            this.rb_tensorrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_tensorrt.Name = "rb_tensorrt";
            this.rb_tensorrt.Size = new System.Drawing.Size(105, 24);
            this.rb_tensorrt.TabIndex = 6;
            this.rb_tensorrt.Text = "TensorRT";
            this.rb_tensorrt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_yolov8_cls);
            this.groupBox2.Controls.Add(this.rb_yolov8_pose);
            this.groupBox2.Controls.Add(this.rb_yolov8_seg);
            this.groupBox2.Controls.Add(this.rb_yolov8_det);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(22, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(536, 48);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "推理模型";
            // 
            // rb_yolov8_cls
            // 
            this.rb_yolov8_cls.AutoSize = true;
            this.rb_yolov8_cls.Location = new System.Drawing.Point(281, 21);
            this.rb_yolov8_cls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_yolov8_cls.Name = "rb_yolov8_cls";
            this.rb_yolov8_cls.Size = new System.Drawing.Size(109, 24);
            this.rb_yolov8_cls.TabIndex = 6;
            this.rb_yolov8_cls.Text = "Yolov8-cls";
            this.rb_yolov8_cls.UseVisualStyleBackColor = true;
            // 
            // rb_yolov8_pose
            // 
            this.rb_yolov8_pose.AutoSize = true;
            this.rb_yolov8_pose.Checked = true;
            this.rb_yolov8_pose.Location = new System.Drawing.Point(426, 21);
            this.rb_yolov8_pose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_yolov8_pose.Name = "rb_yolov8_pose";
            this.rb_yolov8_pose.Size = new System.Drawing.Size(126, 24);
            this.rb_yolov8_pose.TabIndex = 6;
            this.rb_yolov8_pose.TabStop = true;
            this.rb_yolov8_pose.Text = "Yolov8-pose";
            this.rb_yolov8_pose.UseVisualStyleBackColor = true;
            // 
            // rb_yolov8_seg
            // 
            this.rb_yolov8_seg.AutoSize = true;
            this.rb_yolov8_seg.Location = new System.Drawing.Point(153, 21);
            this.rb_yolov8_seg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_yolov8_seg.Name = "rb_yolov8_seg";
            this.rb_yolov8_seg.Size = new System.Drawing.Size(116, 24);
            this.rb_yolov8_seg.TabIndex = 6;
            this.rb_yolov8_seg.Text = "Yolov8-seg";
            this.rb_yolov8_seg.UseVisualStyleBackColor = true;
            // 
            // rb_yolov8_det
            // 
            this.rb_yolov8_det.AutoSize = true;
            this.rb_yolov8_det.Location = new System.Drawing.Point(15, 21);
            this.rb_yolov8_det.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_yolov8_det.Name = "rb_yolov8_det";
            this.rb_yolov8_det.Size = new System.Drawing.Size(113, 24);
            this.rb_yolov8_det.TabIndex = 6;
            this.rb_yolov8_det.Text = "Yolov8-det";
            this.rb_yolov8_det.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "类别文件:";
            // 
            // tb_clas_path
            // 
            this.tb_clas_path.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_clas_path.Location = new System.Drawing.Point(95, 208);
            this.tb_clas_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_clas_path.Name = "tb_clas_path";
            this.tb_clas_path.Size = new System.Drawing.Size(420, 26);
            this.tb_clas_path.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "测试图片:";
            // 
            // tb_test_image
            // 
            this.tb_test_image.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_test_image.Location = new System.Drawing.Point(95, 241);
            this.tb_test_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_test_image.Name = "tb_test_image";
            this.tb_test_image.Size = new System.Drawing.Size(420, 26);
            this.tb_test_image.TabIndex = 4;
            // 
            // btn_choose_claspath
            // 
            this.btn_choose_claspath.Location = new System.Drawing.Point(535, 208);
            this.btn_choose_claspath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_choose_claspath.Name = "btn_choose_claspath";
            this.btn_choose_claspath.Size = new System.Drawing.Size(49, 18);
            this.btn_choose_claspath.TabIndex = 5;
            this.btn_choose_claspath.Text = "选 择";
            this.btn_choose_claspath.UseVisualStyleBackColor = true;
            this.btn_choose_claspath.Click += new System.EventHandler(this.btn_choose_claspath_Click);
            // 
            // btn_choose_testimage
            // 
            this.btn_choose_testimage.Location = new System.Drawing.Point(535, 241);
            this.btn_choose_testimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_choose_testimage.Name = "btn_choose_testimage";
            this.btn_choose_testimage.Size = new System.Drawing.Size(49, 18);
            this.btn_choose_testimage.TabIndex = 5;
            this.btn_choose_testimage.Text = "选 择";
            this.btn_choose_testimage.UseVisualStyleBackColor = true;
            this.btn_choose_testimage.Click += new System.EventHandler(this.btn_choose_testimage_Click);
            // 
            // btn_model_deploy
            // 
            this.btn_model_deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_model_deploy.Location = new System.Drawing.Point(351, 301);
            this.btn_model_deploy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_model_deploy.Name = "btn_model_deploy";
            this.btn_model_deploy.Size = new System.Drawing.Size(99, 27);
            this.btn_model_deploy.TabIndex = 5;
            this.btn_model_deploy.Text = "模 型 推 理";
            this.btn_model_deploy.UseVisualStyleBackColor = true;
            this.btn_model_deploy.Click += new System.EventHandler(this.btn_model_deploy_Click);
            // 
            // btn_engine_conv
            // 
            this.btn_engine_conv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_engine_conv.Location = new System.Drawing.Point(103, 301);
            this.btn_engine_conv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_engine_conv.Name = "btn_engine_conv";
            this.btn_engine_conv.Size = new System.Drawing.Size(99, 27);
            this.btn_engine_conv.TabIndex = 5;
            this.btn_engine_conv.Text = "模 型 转 换";
            this.btn_engine_conv.UseVisualStyleBackColor = true;
            this.btn_engine_conv.Click += new System.EventHandler(this.btn_engine_conv_Click);
            // 
            // FormModelDeployPlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_engine_conv);
            this.Controls.Add(this.btn_model_deploy);
            this.Controls.Add(this.btn_choose_testimage);
            this.Controls.Add(this.btn_choose_claspath);
            this.Controls.Add(this.btn_choose_model_path);
            this.Controls.Add(this.tb_test_image);
            this.Controls.Add(this.tb_clas_path);
            this.Controls.Add(this.tb_model_path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModelDeployPlat";
            this.Text = "Model deployment demonstration platform";
            this.Load += new System.EventHandler(this.FormModelDeployPlat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox tb_model_path;
        private Button btn_choose_model_path;
        private RadioButton rb_openvino;
        private GroupBox groupBox1;
        private RadioButton rb_onnx;
        private RadioButton rb_tensorrt;
        private GroupBox groupBox2;
        private RadioButton rb_yolov8_pose;
        private RadioButton rb_yolov8_seg;
        private RadioButton rb_yolov8_det;
        private Label label3;
        private TextBox tb_clas_path;
        private Label label4;
        private TextBox tb_test_image;
        private Button btn_choose_claspath;
        private Button btn_choose_testimage;
        private Button btn_model_deploy;
        private RadioButton rb_opencv;
        private RadioButton rb_yolov8_cls;
        private Button btn_engine_conv;
    }
}