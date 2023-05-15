using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304_Wapper
{
    public interface DataSource
    {
        void WriteData(string data);

        string GetData();
    }

    public class FileDataSource : DataSource
    {
        public string FileName { get; set; }
        private string _data;

        public FileDataSource(string fileName)
        {
            FileName = fileName;
            _data = "Start";
        }

        public string GetData()
        {
            return _data;
        }

        public void WriteData(string data)
        {
            _data = $"{_data} {data}";
        }
    }

    public class DataSourceDecorator: DataSource
    {
        public DataSource DataSource { get; private set; }

        public DataSourceDecorator(DataSource dataSource)
        {
            DataSource = dataSource;
        }

        public virtual void WriteData(string data)
        {
            DataSource.WriteData(data);
        }

        public virtual string GetData()
        {
            return DataSource.GetData();
        }
    }

    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DataSource dataSource) : base(dataSource)
        {
        }

        public override void WriteData(string data)
        {
            var encryp = $"{data}encryp";
            base.WriteData(encryp.ToString());
        }

        public override string GetData()
        {
            return base.GetData();
        }
    }
}
