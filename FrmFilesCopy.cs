namespace DZ_FileCopySync
{
    public partial class FrmFilesCopy : Form
    {

        private List<ProgressBar> progressBarList;
        private List<string> fileList;
        private static Mutex mutex = new Mutex();
        private void Copy(string outFileName, ProgressBar progressBar)
        {
            byte[] buffer = new byte[8];
            long copied = 0;
            long length = new FileInfo(outFileName).Length;

            using (Stream outStream = File.Create("copied" + outFileName))
            using (Stream inStream = File.OpenRead(outFileName))
            while (copied < length)
            {
                int read = inStream.Read(buffer, 0, buffer.Length);
                outStream.Write(buffer, 0, read);
                copied += read;
                Invoke(() => progressBar.Value = 100 * (int)(copied / length));

                    mutex.WaitOne();
                    Invoke(() => countTotalProgress());
                    mutex.ReleaseMutex();
                }
        }

        private void countTotalProgress()
        {
            int totalProgress = 0;
            

            for (int i = 0; i < progressBarList.Count; i++)
            {
                totalProgress += progressBarList[i].Value;
            }
            pgCopyProgressTotal.Value = totalProgress / progressBarList.Count;
            
        }

        private void startThreads()
        {
            Thread[] threads = new Thread[4];
            for (int i = 0; i < threads.Length; i++)
            {
                int index = i;
                threads[i] = new Thread(() => Copy(fileList[index], progressBarList[index]));
                threads[i].Start();
            }
            //for (int i = 0; i < threads.Length; i++)
            //    threads[i].Join();

            
            
        }


        public FrmFilesCopy()
        {
            InitializeComponent();
            progressBarList = new List<ProgressBar>();
            progressBarList.Add(pgCopyProgress1);
            progressBarList.Add(pgCopyProgress2);
            progressBarList.Add(pgCopyProgress3);
            progressBarList.Add(pgCopyProgress4);

            fileList = new List<string>();
            fileList.Add("file1.txt");
            fileList.Add("file2.txt");
            fileList.Add("file3.txt");
            fileList.Add("file4.txt");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            startThreads();
        }
    }
}
