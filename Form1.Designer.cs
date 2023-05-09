namespace Hepalova_IKM_620b_s_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bStart = new Button();
            label1 = new Label();
            tbInput = new TextBox();
            tClock = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новийToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            роботаToolStripMenuItem = new ToolStripMenuItem();
            пускToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            праНакопичувачіToolStripMenuItem = new ToolStripMenuItem();
            текстовіФайлиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem1 = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem1 = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            sfdSave = new SaveFileDialog();
            ofdOpen = new OpenFileDialog();
            dgwOpen = new DataGridView();
            bSearch = new Button();
            tbSearch = new TextBox();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            statusStrip1 = new StatusStrip();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            splitContainer1 = new SplitContainer();
            LabelStack = new Label();
            StackText = new Label();
            Stacktb = new TextBox();
            Peek = new Button();
            Pop = new Button();
            Push = new Button();
            LabelQueue = new Label();
            QueueText = new Label();
            Queuetb = new TextBox();
            Peek_q = new Button();
            Dequeue = new Button();
            Enqueue = new Button();
            richTextBox1 = new RichTextBox();
            відкритиToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOpen).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // bStart
            // 
            bStart.Location = new Point(307, 177);
            bStart.Name = "bStart";
            bStart.Size = new Size(75, 23);
            bStart.TabIndex = 0;
            bStart.Text = "Пуск";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 84);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // tbInput
            // 
            tbInput.Enabled = false;
            tbInput.Location = new Point(307, 141);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(100, 23);
            tbInput.TabIndex = 2;
            tbInput.KeyPress += tbInput_KeyPress;
            // 
            // tClock
            // 
            tClock.Interval = 25000;
            tClock.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, роботаToolStripMenuItem, довідкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новийToolStripMenuItem, toolStripSeparator1, відкритиToolStripMenuItem, toolStripSeparator2, зберегтиToolStripMenuItem, зберегтиЯкToolStripMenuItem, toolStripSeparator3, вихідToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            новийToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            новийToolStripMenuItem.Size = new Size(165, 22);
            новийToolStripMenuItem.Text = "Новий";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(162, 6);
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            відкритиToolStripMenuItem.Size = new Size(165, 22);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(162, 6);
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            зберегтиToolStripMenuItem.Size = new Size(165, 22);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.Size = new Size(165, 22);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(162, 6);
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            вихідToolStripMenuItem.Size = new Size(165, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // роботаToolStripMenuItem
            // 
            роботаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пускToolStripMenuItem, toolStripSeparator4, праНакопичувачіToolStripMenuItem, текстовіФайлиToolStripMenuItem });
            роботаToolStripMenuItem.Name = "роботаToolStripMenuItem";
            роботаToolStripMenuItem.Size = new Size(58, 20);
            роботаToolStripMenuItem.Text = "Робота";
            // 
            // пускToolStripMenuItem
            // 
            пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            пускToolStripMenuItem.ShortcutKeys = Keys.F9;
            пускToolStripMenuItem.Size = new Size(180, 22);
            пускToolStripMenuItem.Text = "Пуск";
            пускToolStripMenuItem.Click += bStart_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // праНакопичувачіToolStripMenuItem
            // 
            праНакопичувачіToolStripMenuItem.Name = "праНакопичувачіToolStripMenuItem";
            праНакопичувачіToolStripMenuItem.Size = new Size(180, 22);
            праНакопичувачіToolStripMenuItem.Text = "Про накопичувачі";
            // 
            // текстовіФайлиToolStripMenuItem
            // 
            текстовіФайлиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиToolStripMenuItem1, зберегтиЯкToolStripMenuItem1, відкритиToolStripMenuItem1 });
            текстовіФайлиToolStripMenuItem.Name = "текстовіФайлиToolStripMenuItem";
            текстовіФайлиToolStripMenuItem.Size = new Size(180, 22);
            текстовіФайлиToolStripMenuItem.Text = "Текстові файли";
            // 
            // зберегтиToolStripMenuItem1
            // 
            зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            зберегтиToolStripMenuItem1.Size = new Size(180, 22);
            зберегтиToolStripMenuItem1.Text = "Зберегти";
            зберегтиToolStripMenuItem1.Click += зберегтиToolStripMenuItem1_Click;
            // 
            // зберегтиЯкToolStripMenuItem1
            // 
            зберегтиЯкToolStripMenuItem1.Name = "зберегтиЯкToolStripMenuItem1";
            зберегтиЯкToolStripMenuItem1.Size = new Size(180, 22);
            зберегтиЯкToolStripMenuItem1.Text = "Зберегти як...";
            зберегтиЯкToolStripMenuItem1.Click += зберегтиЯкToolStripMenuItem1_Click;
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { проПрограмуToolStripMenuItem });
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(61, 20);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(154, 22);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // sfdSave
            // 
            sfdSave.DefaultExt = "SoM";
            sfdSave.Filter = "рабочие файлы|*.SoM|Все Файлы|*.*";
            // 
            // ofdOpen
            // 
            ofdOpen.DefaultExt = "SoM";
            ofdOpen.FileName = "openFileDialog1";
            ofdOpen.Filter = "рабочие файлы|*.SoM|Все Файлы|*.*";
            // 
            // dgwOpen
            // 
            dgwOpen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOpen.Location = new Point(45, 53);
            dgwOpen.Name = "dgwOpen";
            dgwOpen.RowTemplate.Height = 25;
            dgwOpen.Size = new Size(316, 150);
            dgwOpen.TabIndex = 4;
            dgwOpen.CellContentClick += dgwOpen_CellContentClick;
            // 
            // bSearch
            // 
            bSearch.Location = new Point(536, 71);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(75, 23);
            bSearch.TabIndex = 5;
            bSearch.Text = "Пошук";
            bSearch.UseVisualStyleBackColor = true;
            bSearch.Click += bSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(536, 100);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(100, 23);
            tbSearch.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 421);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(statusStrip1);
            tabPage1.Controls.Add(tbInput);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(bStart);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Введення даних";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(3, 368);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(786, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(dgwOpen);
            tabPage2.Controls.Add(tbSearch);
            tabPage2.Controls.Add(bSearch);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Робота з файлами";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Стек/Черга";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Gray;
            splitContainer1.Panel1.Controls.Add(LabelStack);
            splitContainer1.Panel1.Controls.Add(StackText);
            splitContainer1.Panel1.Controls.Add(Stacktb);
            splitContainer1.Panel1.Controls.Add(Peek);
            splitContainer1.Panel1.Controls.Add(Pop);
            splitContainer1.Panel1.Controls.Add(Push);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Silver;
            splitContainer1.Panel2.Controls.Add(LabelQueue);
            splitContainer1.Panel2.Controls.Add(QueueText);
            splitContainer1.Panel2.Controls.Add(Queuetb);
            splitContainer1.Panel2.Controls.Add(Peek_q);
            splitContainer1.Panel2.Controls.Add(Dequeue);
            splitContainer1.Panel2.Controls.Add(Enqueue);
            splitContainer1.Size = new Size(792, 393);
            splitContainer1.SplitterDistance = 388;
            splitContainer1.TabIndex = 0;
            // 
            // LabelStack
            // 
            LabelStack.AutoSize = true;
            LabelStack.Location = new Point(175, 264);
            LabelStack.Name = "LabelStack";
            LabelStack.Size = new Size(63, 15);
            LabelStack.TabIndex = 5;
            LabelStack.Text = "LabelStack";
            // 
            // StackText
            // 
            StackText.AutoSize = true;
            StackText.Location = new Point(180, 52);
            StackText.Name = "StackText";
            StackText.Size = new Size(32, 15);
            StackText.TabIndex = 4;
            StackText.Text = "Стек";
            // 
            // Stacktb
            // 
            Stacktb.Location = new Point(150, 117);
            Stacktb.Name = "Stacktb";
            Stacktb.Size = new Size(100, 23);
            Stacktb.TabIndex = 3;
            // 
            // Peek
            // 
            Peek.Location = new Point(268, 181);
            Peek.Name = "Peek";
            Peek.Size = new Size(75, 23);
            Peek.TabIndex = 2;
            Peek.Text = "Peek";
            Peek.UseVisualStyleBackColor = true;
            Peek.Click += Peek_Click;
            // 
            // Pop
            // 
            Pop.Location = new Point(163, 181);
            Pop.Name = "Pop";
            Pop.Size = new Size(75, 23);
            Pop.TabIndex = 1;
            Pop.Text = "Pop";
            Pop.UseVisualStyleBackColor = true;
            Pop.Click += Pop_Click;
            // 
            // Push
            // 
            Push.Location = new Point(58, 181);
            Push.Name = "Push";
            Push.Size = new Size(75, 23);
            Push.TabIndex = 0;
            Push.Text = "Push";
            Push.UseVisualStyleBackColor = true;
            Push.Click += Push_Click;
            // 
            // LabelQueue
            // 
            LabelQueue.AutoSize = true;
            LabelQueue.Location = new Point(183, 264);
            LabelQueue.Name = "LabelQueue";
            LabelQueue.Size = new Size(70, 15);
            LabelQueue.TabIndex = 5;
            LabelQueue.Text = "LabelQueue";
            // 
            // QueueText
            // 
            QueueText.AutoSize = true;
            QueueText.Location = new Point(183, 52);
            QueueText.Name = "QueueText";
            QueueText.Size = new Size(39, 15);
            QueueText.TabIndex = 4;
            QueueText.Text = "Черга";
            // 
            // Queuetb
            // 
            Queuetb.Location = new Point(153, 117);
            Queuetb.Name = "Queuetb";
            Queuetb.Size = new Size(100, 23);
            Queuetb.TabIndex = 3;
            // 
            // Peek_q
            // 
            Peek_q.Location = new Point(293, 180);
            Peek_q.Name = "Peek_q";
            Peek_q.Size = new Size(75, 23);
            Peek_q.TabIndex = 2;
            Peek_q.Text = "Peek_q";
            Peek_q.UseVisualStyleBackColor = true;
            Peek_q.Click += Peek_q_Click;
            // 
            // Dequeue
            // 
            Dequeue.Location = new Point(168, 181);
            Dequeue.Name = "Dequeue";
            Dequeue.Size = new Size(75, 23);
            Dequeue.TabIndex = 1;
            Dequeue.Text = "Dequeue";
            Dequeue.UseVisualStyleBackColor = true;
            Dequeue.Click += Dequeue_Click;
            // 
            // Enqueue
            // 
            Enqueue.Location = new Point(32, 182);
            Enqueue.Name = "Enqueue";
            Enqueue.Size = new Size(75, 22);
            Enqueue.TabIndex = 0;
            Enqueue.Text = "Enqueue";
            Enqueue.UseVisualStyleBackColor = true;
            Enqueue.Click += Enqueue_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(440, 183);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(292, 153);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // відкритиToolStripMenuItem1
            // 
            відкритиToolStripMenuItem1.Name = "відкритиToolStripMenuItem1";
            відкритиToolStripMenuItem1.Size = new Size(180, 22);
            відкритиToolStripMenuItem1.Text = "Відкрити";
            відкритиToolStripMenuItem1.Click += відкритиToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOpen).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bStart;
        private Label label1;
        private TextBox tbInput;
        private System.Windows.Forms.Timer tClock;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новийToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem роботаToolStripMenuItem;
        private ToolStripMenuItem пускToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem праНакопичувачіToolStripMenuItem;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private SaveFileDialog sfdSave;
        private OpenFileDialog ofdOpen;
        private DataGridView dgwOpen;
        private Button bSearch;
        private TextBox tbSearch;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private StatusStrip statusStrip1;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private Label LabelStack;
        private Label StackText;
        private TextBox Stacktb;
        private Button Peek;
        private Button Pop;
        private Button Push;
        private Label LabelQueue;
        private Label QueueText;
        private TextBox Queuetb;
        private Button Peek_q;
        private Button Dequeue;
        private Button Enqueue;
        private ToolStripMenuItem текстовіФайлиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem1;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem1;
        private ToolStripMenuItem відкритиToolStripMenuItem1;
        private RichTextBox richTextBox1;
    }
}