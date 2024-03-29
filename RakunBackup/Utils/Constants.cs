﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakunBackup.Utils
{
    class Constants
    {
        public static string ConfigFile = "config.json";
        
        public static string BackupFolder = @"\\backup";
        public static string ConfigError = "Config dosyasına ulaşılamadı ya da okunamadı lütfen tekrar deneyin.";
        public static string MysqlError = "MySql backup sırasında bir hata oluştu.";
        public static string SuccessFtpEmailError = "Yedeklendi, Dosya yüklendi ve Email ile bilgilendirme gönderildi.";
        public static string SuccessEmailError = "Yedeklendi ve Email ile bilgilendirme gönderildi.";
        public static string SuccessFtpError = "Yedeklendi ve Dosya yüklendi.";
        public static string SuccessError = "İşlem başarıyla gerçekleşti.";
        public static string CreateConfigFileError = "Config dosyası oluşturuldu lütfen, config dosyasını düzenleyin.";
        public static string ConfigFileDefualtContext = @"{
  'ftp': {
    'username': '',
    'password': '',
    'path': ''
  },
  'mysql': {
    'server': '',
    'port': 6042,
    'username': '',
    'password': '',
    'database': ''
  },
  'email': {
    'email': [ '','','' ],
    'smtp': '',
    'subject': '',
    'body': '',
    'senderemail': '',
    'password': ''
  },
  'restartTime': 0
}";
    }
}
