 
using CredimaxECR.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CredimaxECR
{
  [Guid("73f50a01-9dc5-409d-b101-f70c341115aa")]
  [ClassInterface(ClassInterfaceType.None)]
  [ComSourceInterfaces("CredimaxECR.comCMXECR+__comCMXECR")]
  [ComClass("73f50a01-9dc5-409d-b101-f70c341115aa", "72fe1453-1651-4ac3-9fd2-d756f3342523", "3ecee5fc-c913-454c-83ab-d2aa91308b32")]
  public class comCMXECR : comCMXECR._comCMXECR
  {
    public const string ClassId = "73f50a01-9dc5-409d-b101-f70c341115aa";
    public const string InterfaceId = "72fe1453-1651-4ac3-9fd2-d756f3342523";
    public const string EventsId = "3ecee5fc-c913-454c-83ab-d2aa91308b32";
    private SerialPort Serial_Port;
    private readonly byte[] STX;
    private readonly byte[] ETX;
    private readonly byte[] ACK;
    private readonly byte[] NAK;
    private string VFI_ECRRcptNum;
    private string VFI_TransType;
    private string VFI_Amount;
    private string VFI_CardNum;
    private string VFI_Expiry;
    private string VFI_CHName;
    private string VFI_CHVerification;
    private string VFI_CardSchemeName;
    private string VFI_TID;
    private string VFI_MID;
    private string VFI_MessNum;
    private string VFI_Batch;
    private string VFI_AuthMode;
    private string VFI_TransSource;
    private string VFI_ApprovalCode;
    private string VFI_VoidReceiptNum;
    private string VFI_DateTime;
    private string VFI_RespCode;
    private string VFI_RespMess;
    private string VFI_EMV_TSI;
    private string VFI_EMV_AC;
    private string VFI_EMV_Label;
    private string VFI_EMV_AID;
    private string VFI_EMV_TVR;
    private string VFI_DBCount;
    private string VFI_CRCount;
    private string VFI_DBAmount;
    private string VFI_CRAmount;
    private string VFI_PYCDBCount;
    private string VFI_PYCCRCount;
    private string VFI_PYCDBAmount;
    private string VFI_PYCCRAmount;
    private string VFI_LHDBCount;
    private string VFI_LHCRCount;
    private string VFI_LHDBAmount;
    private string VFI_LHCRAmount;
    private string VFI_MAC;
    private string VFI_AdditionalInfo;
    private string VFI_CashAmount;
    private string VFI_OrgionalRcptNum;
    private string VFI_MacSourceData;
    private string VFI_TxnDateTime;
    private string VFI_TslNo;
    private string VFI_PTID;
    private string VFI_EMVCID;
    private string VFI_PYCCurr;
    private string VFI_PYCCurrName;
    private string VFI_PYCAmount;
    private string VFI_MarkUp;
    private string VFI_ExchRate;
    private string VFI_OptOut;
    private string VFI_Epp_Optin;
    private bool flgSysConfig;
    private bool flgLic;
    private bool LicVerified;
    private string VFI_Card_First7;
    private string VFI_Card_Last4;
    private string VFI_RRN;
    private string VFI_ReportType;
    private string VFI_AddInfo1;
    private string VFI_AddInfo2;
    private string VFI_AddInfo3;
    private string VFI_AddInfo4;
    private string VFI_AddInfo5;
    private string VFI_AddInfo6;
    private string VFI_AddInfo7;
    private string VFI_AddInfo8;
    private string VFI_AddInfo9;
    private string VFI_AddInfo10;
    private string VFI_AddInInfo1;
    private string VFI_AddInInfo2;
    private string VFI_AddInInfo3;
    private string VFI_AddInInfo4;
    private string VFI_AddInInfo5;
    private string VFI_AddInfo11;
    private string VFI_AddInfo12;
    private string VFI_AddInfo13;
    private string VFI_AddInfo14;
    private string VFI_AddInfo15;
    private string VFI_AddInfo16;
    private string VFI_AddInfo17;
    private string VFI_AddInfo18;
    private string VFI_AddInfo19;
    private string VFI_AddInfo20;
    public string VFI_FailureCode;
    public string VFI_FailureMessage;
    public string VFI_DomesticCurr;
    public string VFI_MerchantName;
    public string VFI_Address1;
    public string VFI_Address2;
    public string VFI_Address3;
    public string VFI_POSApplicationVersion;
    private char FieldFs;
    private char MessageFs;
    private string VFI_XmlRespData;
    private static string strInstruction;
    private bool flgEnc;
    public string VFI_BalanceAmount;
    public string VFI_Last5Txn;
    private string strResMsgType;
    private int VFI_CardTypes;
    private int VFI_DccCardTypes;
    private string VFI_CardType0_CardName;
    private string VFI_CardType0_DBCount;
    private string VFI_CardType0_CRCount;
    private string VFI_CardType0_DBAmount;
    private string VFI_CardType0_CRAmount;
    private string VFI_CardType1_CardName;
    private string VFI_CardType1_DBCount;
    private string VFI_CardType1_CRCount;
    private string VFI_CardType1_DBAmount;
    private string VFI_CardType1_CRAmount;
    private string VFI_CardType2_CardName;
    private string VFI_CardType2_DBCount;
    private string VFI_CardType2_CRCount;
    private string VFI_CardType2_DBAmount;
    private string VFI_CardType2_CRAmount;
    private string VFI_CardType3_CardName;
    private string VFI_CardType3_DBCount;
    private string VFI_CardType3_CRCount;
    private string VFI_CardType3_DBAmount;
    private string VFI_CardType3_CRAmount;
    private string VFI_CardType4_CardName;
    private string VFI_CardType4_DBCount;
    private string VFI_CardType4_CRCount;
    private string VFI_CardType4_DBAmount;
    private string VFI_CardType4_CRAmount;
    private string VFI_CardType5_CardName;
    private string VFI_CardType5_DBCount;
    private string VFI_CardType5_CRCount;
    private string VFI_CardType5_DBAmount;
    private string VFI_CardType5_CRAmount;
    private string VFI_CardType6_CardName;
    private string VFI_CardType6_DBCount;
    private string VFI_CardType6_CRCount;
    private string VFI_CardType6_DBAmount;
    private string VFI_CardType6_CRAmount;
    private string VFI_CardType7_CardName;
    private string VFI_CardType7_DBCount;
    private string VFI_CardType7_CRCount;
    private string VFI_CardType7_DBAmount;
    private string VFI_CardType7_CRAmount;
    private string VFI_CardType8_CardName;
    private string VFI_CardType8_DBCount;
    private string VFI_CardType8_CRCount;
    private string VFI_CardType8_DBAmount;
    private string VFI_CardType8_CRAmount;
    private string VFI_CardType9_CardName;
    private string VFI_CardType9_DBCount;
    private string VFI_CardType9_CRCount;
    private string VFI_CardType9_DBAmount;
    private string VFI_CardType9_CRAmount;
    private string VFI_DccCardType0_CardName;
    private string VFI_DccCardType0_DBCount;
    private string VFI_DccCardType0_CRCount;
    private string VFI_DccCardType0_DBAmount;
    private string VFI_DccCardType0_CRAmount;
    private string VFI_DccCardType1_CardName;
    private string VFI_DccCardType1_DBCount;
    private string VFI_DccCardType1_CRCount;
    private string VFI_DccCardType1_DBAmount;
    private string VFI_DccCardType1_CRAmount;
    private string VFI_DccCardType2_CardName;
    private string VFI_DccCardType2_DBCount;
    private string VFI_DccCardType2_CRCount;
    private string VFI_DccCardType2_DBAmount;
    private string VFI_DccCardType2_CRAmount;
    private string VFI_DccCardType3_CardName;
    private string VFI_DccCardType3_DBCount;
    private string VFI_DccCardType3_CRCount;
    private string VFI_DccCardType3_DBAmount;
    private string VFI_DccCardType3_CRAmount;
    private string VFI_DccCardType4_CardName;
    private string VFI_DccCardType4_DBCount;
    private string VFI_DccCardType4_CRCount;
    private string VFI_DccCardType4_DBAmount;
    private string VFI_DccCardType4_CRAmount;
    private string VFI_DccCardType5_CardName;
    private string VFI_DccCardType5_DBCount;
    private string VFI_DccCardType5_CRCount;
    private string VFI_DccCardType5_DBAmount;
    private string VFI_DccCardType5_CRAmount;
    private string VFI_DccCardType6_CardName;
    private string VFI_DccCardType6_DBCount;
    private string VFI_DccCardType6_CRCount;
    private string VFI_DccCardType6_DBAmount;
    private string VFI_DccCardType6_CRAmount;
    private string VFI_DccCardType7_CardName;
    private string VFI_DccCardType7_DBCount;
    private string VFI_DccCardType7_CRCount;
    private string VFI_DccCardType7_DBAmount;
    private string VFI_DccCardType7_CRAmount;
    private string VFI_DccCardType8_CardName;
    private string VFI_DccCardType8_DBCount;
    private string VFI_DccCardType8_CRCount;
    private string VFI_DccCardType8_DBAmount;
    private string VFI_DccCardType8_CRAmount;
    private string VFI_DccCardType9_CardName;
    private string VFI_DccCardType9_DBCount;
    private string VFI_DccCardType9_CRCount;
    private string VFI_DccCardType9_DBAmount;
    private string VFI_DccCardType9_CRAmount;
    private string strCustData;
    private string SeqType;
    private comCMXECR.Setting Settings;

    public void Install()
    {
      try
      {
        object obj1 = (object) Assembly.LoadFile(Assembly.GetExecutingAssembly().Location);
        object[] objArray;
        bool[] flagArray;
        object obj2 = NewLateBinding.LateGet((object) new RegistrationServices(), (Type) null, "RegisterAssembly", objArray = new object[2]
        {
          obj1,
          (object) AssemblyRegistrationFlags.SetCodeBase
        }, (string[]) null, (Type[]) null, flagArray = new bool[2]
        {
          true,
          false
        });
        if (flagArray[0])
          RuntimeHelpers.GetObjectValue(objArray[0]);
        RuntimeHelpers.GetObjectValue(obj2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void Uninstall()
    {
      try
      {
        object obj1 = (object) Assembly.LoadFile(Assembly.GetExecutingAssembly().Location);
        object[] objArray;
        bool[] flagArray;
        object obj2 = NewLateBinding.LateGet((object) new RegistrationServices(), (Type) null, "UnregisterAssembly", objArray = new object[1]
        {
          obj1
        }, (string[]) null, (Type[]) null, flagArray = new bool[1]
        {
          true
        });
        if (flagArray[0])
          RuntimeHelpers.GetObjectValue(objArray[0]);
        RuntimeHelpers.GetObjectValue(obj2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public comCMXECR()
    {
      this.Serial_Port = new SerialPort();
      this.STX = new byte[1]{ (byte) 2 };
      this.ETX = new byte[1]{ (byte) 3 };
      this.ACK = new byte[1]{ (byte) 6 };
      this.NAK = new byte[1]{ (byte) 21 };
      this.VFI_Epp_Optin = "0";
      this.flgSysConfig = false;
      this.flgLic = false;
      this.LicVerified = false;
      this.VFI_DomesticCurr = "BD";
      this.FieldFs = ',';
      this.MessageFs = '\u001C';
      this.flgEnc = true;
      this.strResMsgType = "";
      this.strCustData = "";
      this.SeqType = "";
      this.Settings = new comCMXECR.Setting();
      try
      {
        this.CreateLoadSettings();
        this.Trace("New " + Assembly.GetExecutingAssembly().GetName().Version.ToString());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private string GetCurrPath()
    {
      string currPath;
      try
      {
        string location = Assembly.GetExecutingAssembly().Location;
        currPath = location.Substring(0, location.LastIndexOf("\\"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        currPath = "C:\\Trace";
        ProjectData.ClearProjectError();
      }
      return currPath;
    }

    private bool ValidateLicense()
    {
      bool flag1;
      if (!this.flgLic)
        flag1 = true;
      else if (this.LicVerified)
      {
        flag1 = true;
      }
      else
      {
        try
        {
          string str1 = "";
          string Left = "";
          this.CreatePreLicense();
          if (Directory.GetFiles(this.GetCurrPath(), "*.lic").Length <= 0)
          {
            int num1 = (int) MessageBox.Show("License file dose not exist.", "License file error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else if (Directory.GetFiles(this.GetCurrPath(), "*.lic").Length > 1)
          {
            int num2 = (int) MessageBox.Show("More than one license file found.", "License file error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
          {
            string file = Directory.GetFiles(this.GetCurrPath(), "*.lic")[0];
            string str2 = this.GetLicFileData(file);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "", false) != 0)
            {
              if (str2.Contains("="))
                str2 = str2.Substring(Strings.InStr(str2, "="));
              bool flag2 = false;
              string Right = "BBKECR".PadRight(8, '*');
              string volumeSerialNumber = this.GetVolumeSerialNumber("C");
              NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
              if (networkInterfaces != null)
              {
                if (networkInterfaces.Length >= 1)
                {
                  int num3 = checked (networkInterfaces.Length - 1);
                  int index = 0;
                  while (index <= num3)
                  {
                    str1 = "";
                    try
                    {
                      str1 = BitConverter.ToString(networkInterfaces[index].GetPhysicalAddress().GetAddressBytes());
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                    }
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "", false) != 0)
                    {
                      string str3 = str1.Replace("-", "") + volumeSerialNumber;
                      str1 = str3.Length <= 24 ? str3.PadRight(24, '#') : str3.Remove(24);
                      Left = this.L_INV_TripleDES(str1, str2);
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left.Substring(0, 8), Right, false) == 0)
                        {
                          flag2 = true;
                          break;
                        }
                        this.Trace("Please check the license for the same appln.");
                      }
                    }
                    checked { ++index; }
                  }
                  if (flag2)
                  {
                    if (Left.Length == 8)
                    {
                      flag1 = true;
                      goto label_40;
                    }
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left.Substring(8), "0000000000000000", false) == 0)
                    {
                      flag1 = true;
                      goto label_40;
                    }
                    else
                    {
                      DateTime exact;
                      try
                      {
                        exact = DateTime.ParseExact(Left.Substring(8, 8), "yyyyMMdd", (IFormatProvider) DateTimeFormatInfo.InvariantInfo);
                      }
                      catch (Exception ex)
                      {
                        ProjectData.SetProjectError(ex);
                        this.Trace("Date Conversion error.");
                        exact = DateTime.ParseExact(Left.Substring(8, 8), "yyyyMMdd", (IFormatProvider) DateTimeFormatInfo.InvariantInfo);
                        ProjectData.ClearProjectError();
                      }
                      string DataStr = Right + Left.Substring(8, 8) + DateAndTime.DateDiff(DateInterval.Day, DateAndTime.Now, exact).ToString("00000000");
                      DateTime now = DateAndTime.Now;
                      if (DateAndTime.DateDiff(DateInterval.Day, now.AddDays(-1.0), exact) < (long) Conversions.ToInteger(Left.Substring(16)) & Conversions.ToInteger(Left.Substring(16)) > 0)
                      {
                        string ResultStr = this.L_TripleDES(str1, DataStr);
                        if (this.SetLicFileData(file, ResultStr))
                        {
                          if (Conversions.ToInteger(DataStr.Substring(16)) <= 30 & Conversions.ToInteger(DataStr.Substring(16)) > 0)
                          {
                            int num4 = (int) MessageBox.Show("Your licence going to expiry in " + Conversions.ToString(Conversions.ToInteger(DataStr.Substring(16))) + " Days", "Licence Expiry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                          }
                        }
                        else
                          goto label_39;
                      }
                      else
                        this.Trace("No Date diff / Expired.");
                      int integer1 = Conversions.ToInteger(DataStr.Substring(8, 8));
                      now = DateAndTime.Now;
                      int integer2 = Conversions.ToInteger(now.ToString("yyyyMMdd"));
                      if (integer1 > integer2 & Conversions.ToInteger(DataStr.Substring(16)) > 0)
                      {
                        flag1 = true;
                        goto label_40;
                      }
                    }
                  }
                }
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.Trace("Error on License Validation:" + exception.Message);
          this.Trace("Error on License Validation:" + exception.ToString());
          ProjectData.ClearProjectError();
        }
label_39:
        flag1 = false;
      }
label_40:
      return flag1;
    }

    private bool ValidateLicense(ref string strMsg)
    {
      bool flag1;
      if (!this.flgLic)
        flag1 = true;
      else if (this.LicVerified)
      {
        flag1 = true;
      }
      else
      {
        try
        {
          string str1 = "";
          string Left = "";
          this.CreatePreLicense();
          if (Directory.GetFiles(this.GetCurrPath(), "*.lic").Length <= 0)
            strMsg = "License file dose not exist in the Path. " + this.GetCurrPath();
          else if (Directory.GetFiles(this.GetCurrPath(), "*.lic").Length > 1)
          {
            strMsg = "More than one license file found. " + this.GetCurrPath();
          }
          else
          {
            string file = Directory.GetFiles(this.GetCurrPath(), "*.lic")[0];
            string str2 = this.GetLicFileData(file);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "", false) != 0)
            {
              if (str2.Contains("="))
                str2 = str2.Substring(Strings.InStr(str2, "="));
              bool flag2 = false;
              string Right = "BBKECR".PadRight(8, '*');
              string volumeSerialNumber = this.GetVolumeSerialNumber("C");
              NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
              if (networkInterfaces != null)
              {
                if (networkInterfaces.Length >= 1)
                {
                  int num1 = checked (networkInterfaces.Length - 1);
                  int index = 0;
                  while (index <= num1)
                  {
                    str1 = "";
                    try
                    {
                      str1 = BitConverter.ToString(networkInterfaces[index].GetPhysicalAddress().GetAddressBytes());
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                    }
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "", false) != 0)
                    {
                      string str3 = str1.Replace("-", "") + volumeSerialNumber;
                      str1 = str3.Length <= 24 ? str3.PadRight(24, '#') : str3.Remove(24);
                      Left = this.L_INV_TripleDES(str1, str2);
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left.Substring(0, 8), Right, false) == 0)
                        {
                          flag2 = true;
                          break;
                        }
                        this.Trace("Please check the license for the same appln.");
                      }
                    }
                    checked { ++index; }
                  }
                  if (flag2)
                  {
                    if (Left.Length == 8)
                    {
                      flag1 = true;
                      goto label_40;
                    }
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left.Substring(8), "0000000000000000", false) == 0)
                    {
                      flag1 = true;
                      goto label_40;
                    }
                    else
                    {
                      DateTime exact;
                      try
                      {
                        exact = DateTime.ParseExact(Left.Substring(8, 8), "yyyyMMdd", (IFormatProvider) DateTimeFormatInfo.InvariantInfo);
                      }
                      catch (Exception ex)
                      {
                        ProjectData.SetProjectError(ex);
                        this.Trace("Date Conversion error.");
                        exact = DateTime.ParseExact(Left.Substring(8, 8), "yyyyMMdd", (IFormatProvider) DateTimeFormatInfo.InvariantInfo);
                        ProjectData.ClearProjectError();
                      }
                      string DataStr = Right + Left.Substring(8, 8) + DateAndTime.DateDiff(DateInterval.Day, DateAndTime.Now, exact).ToString("00000000");
                      DateTime now = DateAndTime.Now;
                      if (DateAndTime.DateDiff(DateInterval.Day, now.AddDays(-1.0), exact) < (long) Conversions.ToInteger(Left.Substring(16)) & Conversions.ToInteger(Left.Substring(16)) > 0)
                      {
                        string ResultStr = this.L_TripleDES(str1, DataStr);
                        if (this.SetLicFileData(file, ResultStr))
                        {
                          if (Conversions.ToInteger(DataStr.Substring(16)) <= 30 & Conversions.ToInteger(DataStr.Substring(16)) > 0)
                          {
                            int num2 = (int) MessageBox.Show("Your licence going to expiry in " + Conversions.ToString(Conversions.ToInteger(DataStr.Substring(16))) + " Days", "Licence Expiry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                          }
                        }
                        else
                          goto label_39;
                      }
                      else
                        this.Trace("No Date diff / Expired.");
                      int integer1 = Conversions.ToInteger(DataStr.Substring(8, 8));
                      now = DateAndTime.Now;
                      int integer2 = Conversions.ToInteger(now.ToString("yyyyMMdd"));
                      if (integer1 > integer2 & Conversions.ToInteger(DataStr.Substring(16)) > 0)
                      {
                        flag1 = true;
                        goto label_40;
                      }
                    }
                  }
                }
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.Trace("Error on License Validation:" + exception.Message);
          this.Trace("Error on License Validation:" + exception.ToString());
          ProjectData.ClearProjectError();
        }
label_39:
        flag1 = false;
      }
label_40:
      return flag1;
    }

    private bool CreatePreLicense()
    {
      bool preLicense;
      try
      {
        if (Directory.GetFiles(this.GetCurrPath(), "*.plic").Length >= 1)
        {
          preLicense = true;
          goto label_11;
        }
        else
        {
          string Left1 = this.PhysicalAddress();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "", false) != 0)
            Left1 = Left1.Replace("-", "");
          string Left2 = Left1 + this.GetVolumeSerialNumber("C");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) == 0)
          {
            int num = (int) MessageBox.Show("Could not Retrive the pre license data, So can not create pre license file.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else
          {
            if (Left2.Length > 24)
              Left2 = Left2.Remove(24);
            string DataStr = Left2.PadRight(24, '#');
            string str = this.L_Triple_DES(DataStr);
            this.SetLicFileData(this.GetCurrPath() + "\\" + MyProject.Computer.Name + ".plic", DataStr.TrimEnd('#') + "=" + str);
            preLicense = true;
            goto label_11;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("Error on CreatePreLicense :" + exception.Message);
        this.Trace("Error on CreatePreLicense :" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      preLicense = false;
label_11:
      return preLicense;
    }

    private string GetLicFileData(string LicFile)
    {
      StreamReader streamReader = (StreamReader) null;
      try
      {
        streamReader = new StreamReader(LicFile);
        LicFile = streamReader.ReadToEnd();
        streamReader.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Read Lic file Failed.");
        LicFile = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
        streamReader?.Dispose();
      }
      return LicFile;
    }

    private bool SetLicFileData(string LicFile, string ResultStr)
    {
      StreamWriter streamWriter = (StreamWriter) null;
      bool flag;
      try
      {
        streamWriter = new StreamWriter(LicFile);
        streamWriter.Write(ResultStr);
        streamWriter.Flush();
        streamWriter.Close();
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Write Lic file Failed");
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        streamWriter?.Dispose();
      }
      return flag;
    }

    private string PhysicalAddress()
    {
      NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
      string str;
      try
      {
        if (networkInterfaces == null | networkInterfaces.Length < 1)
        {
          str = "";
          goto label_7;
        }
        else
        {
          NetworkInterface[] networkInterfaceArray = networkInterfaces;
          int index = 0;
          if (index < networkInterfaceArray.Length)
          {
            str = BitConverter.ToString(networkInterfaceArray[index].GetPhysicalAddress().GetAddressBytes());
            goto label_7;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("Error on PhysicalAddress :" + exception.Message);
        this.Trace("Error on PhysicalAddress :" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      str = "";
label_7:
      return str;
    }

    private string GetVolumeSerialNumber(string driveletter)
    {
      string volumeSerialNumber;
      try
      {
        ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE Name = '" + driveletter + ":'");
        ManagementObjectCollection.ManagementObjectEnumerator enumerator;
        try
        {
          enumerator = managementObjectSearcher.Get().GetEnumerator();
          if (enumerator.MoveNext())
          {
            volumeSerialNumber = Conversions.ToString(enumerator.Current["VolumeSerialNumber"]);
            goto label_8;
          }
        }
        finally
        {
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("Error on GetVolumeSerialNumber :" + exception.Message);
        this.Trace("Error on GetVolumeSerialNumber :" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      volumeSerialNumber = "";
label_8:
      return volumeSerialNumber;
    }

    private string L_INV_TripleDES(string TdesKeyStr, string DataStr)
    {
      byte[] rgbIV = new byte[8]
      {
        (byte) 170,
        (byte) 187,
        (byte) 187,
        (byte) 221,
        (byte) 238,
        byte.MaxValue,
        (byte) 17,
        (byte) 34
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[16];
      byte[] numArray3 = new byte[8];
      byte[] numArray4 = new byte[24];
      string str1 = "";
      string str2;
      try
      {
        if (DataStr.Length % 8 != 0)
          str2 = "";
        else if (TdesKeyStr.Length != 24)
        {
          str2 = "";
        }
        else
        {
          byte[] sourceArray = this.ByteStrToByte(DataStr);
          byte[] bytes = Encoding.ASCII.GetBytes(TdesKeyStr);
          int num = checked (sourceArray.Length - 1);
          int sourceIndex = 0;
          while (sourceIndex <= num)
          {
            byte[] numArray5 = new byte[8];
            byte[] numArray6 = new byte[16];
            Array.Copy((Array) sourceArray, sourceIndex, (Array) numArray6, 0, 8);
            cryptoTransform = cryptoServiceProvider.CreateDecryptor(bytes, rgbIV);
            cryptoTransform.TransformBlock(numArray6, 0, 16, numArray5, 0);
            str1 += Encoding.ASCII.GetString(numArray5);
            checked { sourceIndex += 8; }
          }
          str2 = str1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("INV_TripleDES Error : " + ex.Message);
        str2 = (string) null;
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str2;
    }

    private string ByteToTraceStr(byte[] msg, int Llen)
    {
      string traceStr = "";
      try
      {
        int num = checked (Llen - 1);
        int index = 0;
        while (index <= num)
        {
          traceStr = !(msg[index] < (byte) 32 | msg[index] > (byte) 127) ? traceStr + Conversions.ToString(Strings.Chr((int) msg[index])) : traceStr + "<" + Conversion.Hex(msg[index]) + ">";
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("ByteToTraceStr Error : " + exception.Message);
        this.Trace("ByteToTraceStr Error : " + exception.ToString());
        traceStr = "";
        ProjectData.ClearProjectError();
      }
      return traceStr;
    }

    private string L_TripleDES(string tdesKeyStr, string DataStr)
    {
      byte[] rgbIV = new byte[8]
      {
        (byte) 170,
        (byte) 187,
        (byte) 187,
        (byte) 221,
        (byte) 238,
        byte.MaxValue,
        (byte) 17,
        (byte) 34
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[24];
      byte[] numArray3 = new byte[8];
      string str1 = "";
      string str2;
      try
      {
        if (DataStr.Length % 8 != 0)
          str2 = "";
        else if (tdesKeyStr.Length != 24)
        {
          str2 = "";
        }
        else
        {
          byte[] bytes1 = Encoding.ASCII.GetBytes(tdesKeyStr);
          byte[] bytes2 = Encoding.ASCII.GetBytes(DataStr);
          int num = checked (DataStr.Length - 1);
          int inputOffset = 0;
          while (inputOffset <= num)
          {
            byte[] outputBuffer = new byte[8];
            cryptoTransform = cryptoServiceProvider.CreateEncryptor(bytes1, rgbIV);
            cryptoTransform.TransformBlock(bytes2, inputOffset, 8, outputBuffer, 0);
            str1 += BitConverter.ToString(outputBuffer).Replace("-", "");
            checked { inputOffset += 8; }
          }
          str2 = str1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("TripleDES Error : " + ex.Message);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str2;
    }

    private string L_Triple_DES(string DataStr)
    {
      byte[] rgbIV = new byte[8]
      {
        (byte) 170,
        (byte) 187,
        (byte) 187,
        (byte) 221,
        (byte) 238,
        byte.MaxValue,
        (byte) 17,
        (byte) 34
      };
      byte[] rgbKey = new byte[24]
      {
        (byte) 17,
        (byte) 34,
        (byte) 51,
        (byte) 68,
        (byte) 85,
        (byte) 102,
        (byte) 119,
        (byte) 136,
        (byte) 153,
        (byte) 0,
        (byte) 170,
        (byte) 187,
        (byte) 187,
        (byte) 221,
        (byte) 238,
        byte.MaxValue,
        (byte) 161,
        (byte) 178,
        (byte) 195,
        (byte) 212,
        (byte) 229,
        (byte) 246,
        (byte) 171,
        (byte) 205
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[8];
      string str1 = "";
      string str2;
      try
      {
        if (DataStr.Length % 8 != 0)
        {
          str2 = "";
        }
        else
        {
          byte[] bytes = Encoding.ASCII.GetBytes(DataStr);
          int num = checked (DataStr.Length - 1);
          int inputOffset = 0;
          while (inputOffset <= num)
          {
            byte[] outputBuffer = new byte[8];
            cryptoTransform = cryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV);
            cryptoTransform.TransformBlock(bytes, inputOffset, 8, outputBuffer, 0);
            str1 += BitConverter.ToString(outputBuffer).Replace("-", "");
            checked { inputOffset += 8; }
          }
          str2 = str1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("L_Triple_DES Error : " + ex.Message);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str2;
    }

    private bool LoadSettings()
    {
      bool flag;
      try
      {
        this.LoadSettings("");
        flag = true;
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("LoadSettings Error : " + exception.Message);
        this.Trace("LoadSettings Error : " + exception.ToString());
        ProjectData.ClearProjectError();
      }
      flag = false;
label_3:
      return flag;
    }

    private bool LoadSettings(string TermId)
    {
      bool flag;
      try
      {
        if (this.flgSysConfig)
        {
          flag = true;
        }
        else
        {
          this.CreateLoadSettings();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.Settings.PortName, "", false) == 0)
            this.Settings.PortName = "COM1";
          if (this.Settings.BaudRate <= 0)
            this.Settings.BaudRate = 19200;
          if (this.Settings.Timeout <= (short) 0)
            this.Settings.Timeout = (short) 30;
          if (this.Settings.TxnTimeout <= (short) 0)
            this.Settings.TxnTimeout = (short) 90;
          if (this.Settings.UploadTimeout <= (short) 0)
            this.Settings.UploadTimeout = (short) 300;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.Settings.TracePath, "", false) == 0)
            this.Settings.TracePath = this.GetCurrPath();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.Settings.LICData, "", false) == 0)
            this.Settings.LICData = "15CEB6E991F3279E";
          if (this.Settings.DelayTimeout <= (short) 0)
            this.Settings.DelayTimeout = (short) 5;
          this.Trace("LoadSettings Success.", TermId);
          flag = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("LoadSettings Error : " + exception.Message, TermId);
        this.Trace("LoadSettings Error : " + exception.ToString(), TermId);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public bool VFI_InitializeAll()
    {
      bool flag;
      try
      {
        this.Trace("VFI_InitializeAll Starts.");
        this.ClearData();
        this.VFI_RespCode = "00";
        this.VFI_RespMess = "Successfully Proessed !!!";
        this.Trace("VFI_InitializeAll :" + this.VFI_RespMess);
        flag = true;
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.VFI_RespCode = "99";
        this.VFI_RespMess = exception.Message;
        this.Trace("VFI_InitializeAll Err:" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      flag = false;
label_3:
      return flag;
    }

    private void ClearData()
    {
      try
      {
        this.VFI_ECRRcptNum = "";
        this.VFI_TransType = "";
        this.VFI_Amount = "";
        this.VFI_CashAmount = "";
        this.VFI_VoidReceiptNum = "";
        this.VFI_AdditionalInfo = "";
        this.ClearResData();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Clear data Err:" + ex.ToString());
        ProjectData.ClearProjectError();
      }
    }

    private void ClearResData()
    {
      try
      {
        this.VFI_CardNum = "";
        this.VFI_Expiry = "";
        this.VFI_CHName = "";
        this.VFI_MessNum = "";
        this.VFI_CardSchemeName = "";
        this.VFI_TransSource = "";
        this.VFI_AuthMode = "";
        this.VFI_CHVerification = "";
        this.VFI_RespCode = "";
        this.VFI_RespMess = "";
        this.VFI_ApprovalCode = "";
        this.VFI_DateTime = "";
        this.VFI_EMV_Label = "";
        this.VFI_EMV_AID = "";
        this.VFI_EMV_TVR = "";
        this.VFI_EMV_TSI = "";
        this.VFI_EMV_AC = "";
        this.VFI_DBCount = "";
        this.VFI_DBAmount = "";
        this.VFI_CRCount = "";
        this.VFI_CRAmount = "";
        this.VFI_TID = "";
        this.VFI_MID = "";
        this.VFI_Batch = "";
        this.VFI_MAC = "";
        this.VFI_EMVCID = "";
        this.VFI_ExchRate = "";
        this.VFI_PYCAmount = "";
        this.VFI_MarkUp = "";
        this.VFI_PYCCurr = "";
        this.VFI_PYCCurrName = "";
        this.VFI_OptOut = "";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Clear Res data Err:" + ex.ToString());
        ProjectData.ClearProjectError();
      }
    }

    public string VFI_GetFieldValue(short FieldID)
    {
      string fieldValue = "-1";
      try
      {
        this.Trace("VFI_GetFieldValue Starts" + Conversion.Str((object) FieldID));
        if (FieldID <= (short) 0 | FieldID > (short) 46)
        {
          this.Trace("VFI_GetFieldValue Err : Invalid field ID ");
          fieldValue = "-1";
        }
        else
        {
          switch (FieldID)
          {
            case 1:
              fieldValue = this.VFI_ECRRcptNum;
              break;
            case 2:
              fieldValue = this.VFI_TransType;
              break;
            case 3:
              fieldValue = this.VFI_Amount;
              break;
            case 4:
              fieldValue = this.VFI_CashAmount;
              break;
            case 5:
              fieldValue = this.VFI_CardNum;
              break;
            case 6:
              fieldValue = this.VFI_Expiry;
              break;
            case 7:
              fieldValue = this.VFI_CHName;
              break;
            case 8:
              fieldValue = this.VFI_MessNum;
              break;
            case 9:
              fieldValue = this.VFI_CardSchemeName;
              break;
            case 10:
              fieldValue = this.VFI_TransSource;
              break;
            case 11:
              fieldValue = this.VFI_AuthMode;
              break;
            case 12:
              fieldValue = this.VFI_CHVerification;
              break;
            case 13:
              fieldValue = this.VFI_RespCode;
              break;
            case 14:
              fieldValue = this.VFI_RespMess;
              break;
            case 15:
              fieldValue = this.VFI_ApprovalCode;
              break;
            case 16:
              fieldValue = this.VFI_DateTime;
              break;
            case 17:
              fieldValue = this.VFI_EMV_Label;
              break;
            case 18:
              fieldValue = this.VFI_EMV_AID;
              break;
            case 19:
              fieldValue = this.VFI_EMV_TVR;
              break;
            case 20:
              fieldValue = this.VFI_EMV_TSI;
              break;
            case 21:
              fieldValue = this.VFI_EMV_AC;
              break;
            case 26:
              fieldValue = this.VFI_VoidReceiptNum;
              break;
            case 27:
              fieldValue = this.VFI_DBCount;
              break;
            case 28:
              fieldValue = this.VFI_CRCount;
              break;
            case 29:
              fieldValue = this.VFI_DBAmount;
              break;
            case 30:
              fieldValue = this.VFI_CRAmount;
              break;
            case 31:
              fieldValue = this.VFI_AdditionalInfo;
              break;
            case 33:
              fieldValue = this.VFI_TID;
              break;
            case 34:
              fieldValue = this.VFI_Batch;
              break;
            case 37:
              fieldValue = this.VFI_EMVCID;
              break;
            case 38:
              fieldValue = this.VFI_ExchRate;
              break;
            case 39:
              fieldValue = this.VFI_PYCAmount;
              break;
            case 40:
              fieldValue = this.VFI_MarkUp;
              break;
            case 41:
              fieldValue = this.VFI_PYCCurr;
              break;
            case 42:
              fieldValue = this.VFI_PYCCurrName;
              break;
            case 43:
              fieldValue = this.VFI_OptOut;
              break;
          }
          this.Trace("VFI_GetFieldValue - Field Id : " + FieldID.ToString() + ", FieldValue : " + fieldValue);
          this.Trace("VFI_GetFieldValue Success ");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetFieldValue Err :" + Information.Err().Description);
        fieldValue = "-2";
        ProjectData.ClearProjectError();
      }
      return fieldValue;
    }

    public bool VFI_LoadSetting()
    {
      bool flag;
      try
      {
        if (!this.LoadSettings())
        {
          this.VFI_RespCode = "99";
          this.VFI_RespMess = "Error on Load settings.";
          this.Trace("Error on Load Setting " + this.VFI_RespMess);
          flag = false;
        }
        else
        {
          this.VFI_RespCode = "00";
          this.VFI_RespMess = "Successfully Proessed !!!";
          this.Trace("Load Setting " + this.VFI_RespMess);
          flag = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.VFI_RespCode = "99";
        this.VFI_RespMess = exception.Message;
        this.Trace("Load setting Err :" + exception.ToString());
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public bool VFI_DoSetup()
    {
      bool flag;
      try
      {
        flag = this.VFI_DoSetup(ref this.VFI_RespCode, ref this.VFI_RespMess);
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.VFI_RespCode = "99";
        this.VFI_RespMess = exception.Message;
        this.Trace("Do Setup Err :" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      flag = false;
label_3:
      return flag;
    }

    public bool VFI_DoSetup(ref string RespCode, ref string RespMess)
    {
      bool flag;
      try
      {
        this.CreateLoadSettings();
        RespCode = "99";
        RespMess = "System Error";
        if (new frmDosetup().ShowDialog() != DialogResult.Yes)
        {
          RespCode = "99";
          RespMess = "Do Setup Failed !!!";
        }
        else
        {
          RespCode = "00";
          RespMess = "Successfully Proessed !!!";
        }
        this.Trace("Do Setup " + RespMess);
        flag = true;
        goto label_6;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        RespCode = "99";
        RespMess = exception.Message;
        this.Trace("Do Setup Err :" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      flag = false;
label_6:
      return flag;
    }

    public bool VFI_SetFieldValue(short FieldID, string TValue)
    {
      bool flag;
      try
      {
        this.Trace("VFI_SetFieldValue Starts : " + Conversion.Str((object) FieldID) + " Value: " + TValue);
        if (FieldID <= (short) 0 | FieldID > (short) 46)
        {
          this.Trace("VFI_SetFieldValue : Invalid Field ID");
        }
        else
        {
          switch (FieldID)
          {
            case 1:
              this.VFI_ECRRcptNum = TValue;
              break;
            case 2:
              this.VFI_TransType = TValue;
              break;
            case 3:
              this.VFI_Amount = TValue;
              break;
            case 4:
              this.VFI_CashAmount = TValue;
              break;
            case 5:
              this.VFI_CardNum = TValue;
              break;
            case 6:
              this.VFI_Expiry = TValue;
              break;
            case 7:
              this.VFI_CHName = TValue;
              break;
            case 8:
              this.VFI_MessNum = TValue;
              break;
            case 9:
              this.VFI_CardSchemeName = TValue;
              break;
            case 10:
              this.VFI_TransSource = TValue;
              break;
            case 11:
              this.VFI_AuthMode = TValue;
              break;
            case 12:
              this.VFI_CHVerification = TValue;
              break;
            case 13:
              this.VFI_RespCode = TValue;
              break;
            case 14:
              this.VFI_RespMess = TValue;
              break;
            case 15:
              this.VFI_ApprovalCode = TValue;
              break;
            case 16:
              this.VFI_DateTime = TValue;
              break;
            case 17:
              this.VFI_EMV_Label = TValue;
              break;
            case 18:
              this.VFI_EMV_AID = TValue;
              break;
            case 19:
              this.VFI_EMV_TVR = TValue;
              break;
            case 20:
              this.VFI_EMV_TSI = TValue;
              break;
            case 21:
              this.VFI_EMV_AC = TValue;
              break;
            case 26:
              this.VFI_VoidReceiptNum = TValue;
              break;
            case 27:
              this.VFI_DBCount = TValue;
              break;
            case 28:
              this.VFI_CRCount = TValue;
              break;
            case 29:
              this.VFI_DBAmount = TValue;
              break;
            case 30:
              this.VFI_CRAmount = TValue;
              break;
            case 31:
              this.VFI_AdditionalInfo = TValue;
              break;
            case 33:
              this.VFI_TID = TValue;
              break;
            case 34:
              this.VFI_Batch = TValue;
              break;
            case 37:
              this.VFI_EMVCID = TValue;
              break;
            case 38:
              this.VFI_ExchRate = TValue;
              break;
            case 39:
              this.VFI_PYCAmount = TValue;
              break;
            case 40:
              this.VFI_MarkUp = TValue;
              break;
            case 41:
              this.VFI_PYCCurr = TValue;
              break;
            case 42:
              this.VFI_PYCCurrName = TValue;
              break;
            case 43:
              this.VFI_OptOut = TValue;
              break;
          }
          this.Trace("VFI_SetFieldValue Success");
          flag = true;
          goto label_42;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_SetFieldValue Err:" + Information.Err().Description);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_42:
      return flag;
    }

    public bool VFI_GetAuth()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TransType = this.VFI_TransType;
        clsMem.VFI_Amount = this.VFI_Amount;
        clsMem.VFI_CashAmount = this.VFI_CashAmount;
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem.VFI_AdditionalInfo = this.VFI_AdditionalInfo;
        clsMem.VFI_ApprovalCode = this.VFI_ApprovalCode;
        clsMem.VFI_RRN = this.VFI_RRN;
        clsMem = this.VFI_GetAuth(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_VoidTrans()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_VoidReceiptNum = this.VFI_VoidReceiptNum;
        clsMem.VFI_Amount = this.VFI_Amount;
        clsMem.VFI_CashAmount = this.VFI_CashAmount;
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem.VFI_AdditionalInfo = this.VFI_AdditionalInfo;
        clsMem = this.VFI_VoidTrans(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_Settle()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem = this.VFI_Settle(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_GetMaskedCardNo()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem = this.VFI_GetMaskedCardNo(clsMem, false);
        this.SetResData(clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_GetAuth(
      string TransType,
      string Amount,
      string CashAmount,
      string AdditionalInfo,
      string ECRRcptNum,
      ref string RespCode,
      ref string RespMess)
    {
      bool auth = false;
      try
      {
        this.VFI_TransType = TransType;
        this.VFI_Amount = Amount;
        this.VFI_CashAmount = CashAmount;
        this.VFI_AdditionalInfo = AdditionalInfo;
        this.VFI_ECRRcptNum = ECRRcptNum;
        auth = this.VFI_GetAuth();
        RespCode = this.VFI_RespCode;
        RespMess = this.VFI_RespMess;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        RespCode = "99";
        RespMess = exception.Message;
        this.Trace("GetAuth1 Err:" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      return auth;
    }

    public bool VFI_VoidTrans(
      string Amount,
      string VoidReceiptNum,
      string CashAmount,
      string ECRRcptNum,
      string AdditionalInfo,
      ref string RespCode,
      ref string RespMess,
      string OptInOut)
    {
      bool flag = false;
      try
      {
        this.VFI_Amount = Amount;
        this.VFI_VoidReceiptNum = VoidReceiptNum;
        this.VFI_CashAmount = CashAmount;
        this.VFI_ECRRcptNum = ECRRcptNum;
        this.VFI_AdditionalInfo = AdditionalInfo;
        this.VFI_OptOut = OptInOut;
        flag = this.VFI_VoidTrans();
        RespCode = this.VFI_RespCode;
        RespMess = this.VFI_RespMess;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        RespCode = "99";
        RespMess = exception.Message;
        this.Trace("VFI_VoidTrans1 Err:" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public bool VFI_Settle(ref string RespCode, ref string RespMess)
    {
      bool flag = false;
      try
      {
        flag = this.VFI_Settle();
        RespCode = this.VFI_RespCode;
        RespMess = this.VFI_RespMess;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        RespCode = "99";
        RespMess = exception.Message;
        this.Trace("VFI_Settle1 Err:" + exception.ToString());
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool ReqResPkt(
      ref SerialPort Serial_Port,
      string strData,
      ref clsDataFields clsMem,
      string strMsgType,
      int tTimeout,
      bool flgXml,
      bool flgDelay)
    {
      bool flag = false;
      try
      {
        if (!this.SendReqPkt(ref Serial_Port, strData, ref clsMem, this.Settings.Delay))
        {
          clsMem.VFI_RespCode = "Z7";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
            clsMem.VFI_RespMess = "Send Error";
          this.Trace("ReqResPkt Exchange error.", clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else if (!this.ResPktProcess(Serial_Port, strMsgType, tTimeout, ref clsMem, flgXml))
        {
          this.Trace("ReqResPkt process error.", clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
          flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private string InvTripleDESPkt(string DataStr)
    {
      byte[] rgbIV = new byte[8];
      byte[] rgbKey = new byte[24]
      {
        (byte) 89,
        (byte) 73,
        (byte) 117,
        (byte) 249,
        (byte) 51,
        (byte) 212,
        (byte) 158,
        (byte) 202,
        (byte) 100,
        (byte) 44,
        (byte) 165,
        (byte) 191,
        (byte) 2,
        (byte) 107,
        (byte) 5,
        (byte) 151,
        (byte) 89,
        (byte) 73,
        (byte) 117,
        (byte) 249,
        (byte) 51,
        (byte) 212,
        (byte) 158,
        (byte) 202
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[16];
      byte[] numArray3 = new byte[8];
      string str = "";
      try
      {
        if ((int) checked ((short) DataStr.Length) % 16 == 0)
        {
          byte[] sourceArray = this.ByteStrToByte(DataStr);
          int num = checked (sourceArray.Length - 1);
          int sourceIndex = 0;
          while (sourceIndex <= num)
          {
            byte[] numArray4 = new byte[16];
            byte[] numArray5 = new byte[16];
            Array.Copy((Array) sourceArray, sourceIndex, (Array) numArray5, 0, 8);
            cryptoTransform = cryptoServiceProvider.CreateDecryptor(rgbKey, rgbIV);
            cryptoTransform.TransformBlock(numArray5, 0, 16, numArray4, 0);
            str += Encoding.ASCII.GetString(numArray4, 0, 8);
            checked { sourceIndex += 8; }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        str = (string) null;
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str;
    }

    private string DecryPkt(string strInput)
    {
      string str = "";
      try
      {
        str = this.InvTripleDESPkt(strInput);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("DecryPin :" + ex.ToString());
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private string EncryPkt(string strInput) => this.TripleDESpkt(strInput);

    private string AESDec(string strData, string strKey)
    {
      string str1;
      string str2;
      try
      {
        if (strData.Length % 8 != 0)
        {
          str1 = "";
          goto label_12;
        }
        else if (strKey.Length % 8 != 0)
        {
          str1 = "";
          goto label_12;
        }
        else
        {
          if (strKey.Length == 16)
            strKey += strKey.Substring(0, 8);
          if (strKey.Length > 32)
            strKey = strKey.Substring(0, 32);
          byte[] bytes = Encoding.ASCII.GetBytes(strKey);
          str2 = this.AESDec(strData, bytes);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("AESDec Error : " + ex.Message);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      str1 = str2;
label_12:
      return str1;
    }

    private string AESDec(string strData, byte[] TKey)
    {
      AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider();
      byte[] iv = new byte[16];
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[8];
      string str1 = "";
      string str2;
      string str3;
      try
      {
        if (strData.Length % 8 != 0)
        {
          str2 = "";
          goto label_19;
        }
        else
        {
          byte[] buffer = this.ByteStrToByte(strData);
          int count = buffer.Length;
          byte[] numArray3 = new byte[checked (count - 1 + 1)];
          cryptoServiceProvider.Padding = PaddingMode.PKCS7;
          ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor(TKey, iv);
          using (MemoryStream memoryStream = new MemoryStream(buffer))
          {
            using (CryptoStream input = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
            {
              using (BinaryReader binaryReader = new BinaryReader((Stream) input))
                count = binaryReader.Read(numArray3, 0, numArray3.Length);
            }
          }
          str3 = str1 + Encoding.ASCII.GetString(numArray3, 0, count);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("AESDec Error : " + ex.Message);
        str3 = "";
        ProjectData.ClearProjectError();
      }
      str2 = str3;
label_19:
      return str2;
    }

    private string AESEnc(string strData, string strKey)
    {
      string str1;
      string str2;
      try
      {
        if (strKey.Length % 8 != 0)
        {
          str1 = "";
          goto label_10;
        }
        else
        {
          if (strKey.Length == 16)
            strKey += strKey.Substring(0, 8);
          if (strKey.Length > 32)
            strKey = strKey.Substring(0, 32);
          byte[] bytes = Encoding.ASCII.GetBytes(strKey);
          str2 = this.AESEnc(strData, bytes);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("AESEnc Error : " + ex.Message);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      str1 = str2;
label_10:
      return str1;
    }

    private string AESEnc(string strData, byte[] TKey)
    {
      AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider();
      byte[] iv = new byte[16];
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[8];
      string str = "";
      try
      {
        byte[] bytes = Encoding.ASCII.GetBytes(strData);
        TKey = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) TKey, (Array) new byte[32]);
        numArray1 = new byte[checked (bytes.Length - 1 + 1)];
        ICryptoTransform encryptor = cryptoServiceProvider.CreateEncryptor(TKey, iv);
        MemoryStream memoryStream = new MemoryStream();
        using (CryptoStream output = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
        {
          using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
            binaryWriter.Write(bytes);
          str = this.ByteToBytestr(memoryStream.ToArray());
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("AESEnc Error : " + ex.Message);
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    internal byte[] AESDec(byte[] Data, byte[] Key, byte[] IV)
    {
      AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider();
      byte[] buffer = new byte[8];
      try
      {
        if (Data.Length % 8 == 0)
        {
          if (Key.Length % 8 == 0)
          {
            if (Key.Length == 24)
            {
              Key = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) Key, (Array) new byte[32]);
              Array.Copy((Array) Key, 0, (Array) Key, 24, 8);
            }
            if (IV == null)
              IV = new byte[16];
            if (IV.Length != 16)
              IV = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) IV, (Array) new byte[16]);
            if (Key.Length > 32)
              Key = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) Key, (Array) new byte[32]);
            Key = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) Key, (Array) new byte[32]);
            buffer = new byte[checked (Data.Length - 1 + 1)];
            cryptoServiceProvider.Mode = CipherMode.ECB;
            cryptoServiceProvider.Padding = PaddingMode.Zeros;
            ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor(Key, IV);
            using (MemoryStream memoryStream = new MemoryStream(Data))
            {
              using (CryptoStream input = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
              {
                using (BinaryReader binaryReader = new BinaryReader((Stream) input))
                  binaryReader.Read(buffer, 0, buffer.Length);
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("AESDec Error : " + ex.Message);
        buffer = (byte[]) null;
        ProjectData.ClearProjectError();
      }
      return buffer;
    }

    private byte[] AESEnc(byte[] Data, byte[] Key, byte[] IV)
    {
      AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider();
      byte[] numArray = new byte[8];
      try
      {
        if (Key.Length % 8 == 0)
        {
          if (Key.Length == 24)
          {
            Key = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) Key, (Array) new byte[32]);
            Array.Copy((Array) Key, 0, (Array) Key, 24, 8);
          }
          if (IV == null)
            IV = new byte[16];
          if (IV.Length != 16)
            IV = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) IV, (Array) new byte[16]);
          if (Key.Length > 32)
            Key = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) Key, (Array) new byte[32]);
          Key = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) Key, (Array) new byte[32]);
          numArray = new byte[checked (Data.Length - 1 + 1)];
          cryptoServiceProvider.Mode = CipherMode.ECB;
          cryptoServiceProvider.Padding = PaddingMode.Zeros;
          ICryptoTransform encryptor = cryptoServiceProvider.CreateEncryptor(Key, IV);
          MemoryStream memoryStream = new MemoryStream();
          using (CryptoStream output = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
          {
            using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
              binaryWriter.Write(Data);
            numArray = memoryStream.ToArray();
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("AESEnc Error : " + ex.Message);
        numArray = (byte[]) null;
        ProjectData.ClearProjectError();
      }
      return numArray;
    }

    private string ByteToBytestr(byte[] Data)
    {
      string bytestr = "";
      try
      {
        bytestr = this.ByteToBytestr(Data, 0, Data.Length);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return bytestr;
    }

    private string ByteToBytestr(byte[] Data, int index, int llen)
    {
      string bytestr = "";
      try
      {
        bytestr = BitConverter.ToString(Data, index, llen).ToString().Replace("-", "");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return bytestr;
    }

    private string GetMsgType(byte[] RxPkt, int StartingIndex, int Llen)
    {
      string msgType = "";
      try
      {
        if (!this.flgEnc)
        {
          msgType = Encoding.ASCII.GetString(RxPkt, StartingIndex, Llen);
        }
        else
        {
          msgType = this.DecryPkt(Encoding.ASCII.GetString(RxPkt, StartingIndex, 16));
          msgType = msgType.Substring(0, Llen);
        }
        Llen = (int) RxPkt[StartingIndex] != Strings.Asc("O02".Substring(0, 1)) ? "C".Length : "O02".Length;
        msgType = msgType.Substring(0, Llen);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("GetMsgType error : " + exception.Message);
        this.Trace("GetMsgType error : " + exception.ToString());
        ProjectData.ClearProjectError();
      }
      return msgType;
    }

    private bool Open_Port1(
      ref SerialPort Serial_Port,
      string PortName,
      int BaudRate,
      bool flgDtrRts,
      string TermId)
    {
      bool flag;
      try
      {
        string strMsg = "";
        flag = this.Open_Port(ref Serial_Port, PortName, BaudRate, flgDtrRts, TermId, ref strMsg);
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Open_Port Error : " + ex.Message, TermId);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_3:
      return flag;
    }

    private bool Open_Port(
      ref SerialPort Serial_Port,
      string PortName,
      int BaudRate,
      bool flgDtrRts,
      string TermId,
      ref string strMsg)
    {
      bool flag;
      try
      {
        this.Trace("Open_Port Start ", TermId);
        try
        {
          if (Serial_Port.IsOpen)
          {
            this.Trace("Already port is opened,It is restart the port. ", TermId);
            Serial_Port.Close();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.Trace("Open_Port : " + ex.Message, TermId);
          ProjectData.ClearProjectError();
        }
        Serial_Port.PortName = PortName;
        Serial_Port.BaudRate = BaudRate;
        Serial_Port.Parity = Parity.None;
        Serial_Port.DataBits = 8;
        Serial_Port.StopBits = StopBits.One;
        if (flgDtrRts)
        {
          Serial_Port.RtsEnable = true;
          Serial_Port.DtrEnable = true;
        }
        Serial_Port.Handshake = Handshake.None;
        Serial_Port.ReadTimeout = 1000;
        Serial_Port.WriteTimeout = 1000;
        Serial_Port.Open();
        this.Trace("Port open successfully ...........", TermId);
        if (Serial_Port.WriteBufferSize < 1000)
          this.Trace("WriteBufferSize: " + Serial_Port.WriteBufferSize.ToString(), TermId);
        if (Serial_Port.ReadBufferSize < 1000)
          this.Trace("ReadBufferSize: " + Serial_Port.ReadBufferSize.ToString(), TermId);
        flag = true;
        goto label_13;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        strMsg = "Port Error : " + exception.Message;
        this.Trace("Open_Port Error : " + exception.Message, TermId);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_13:
      return flag;
    }

    private bool Close_Port(ref SerialPort Serial_Port, string TermId)
    {
      bool flag = false;
      try
      {
        this.Trace("Port closing", this.VFI_TID);
        Thread.Sleep(this.Settings.SleepTime);
        if (Information.IsNothing((object) Serial_Port))
        {
          this.Trace("Already Done.", this.VFI_TID);
          flag = true;
        }
        else if (!Serial_Port.IsOpen)
        {
          this.Trace("Already Done", this.VFI_TID);
          flag = true;
        }
        else
        {
          while (!Information.IsNothing((object) Serial_Port) && Serial_Port.IsOpen && Serial_Port.BytesToWrite >= 1)
          {
            Thread.Sleep(this.Settings.SleepTime);
            if (this.Settings.flgDoEvent)
              Application.DoEvents();
            this.Trace("BytesToWrite", TermId);
          }
          Thread.Sleep(this.Settings.SleepTime);
          if (this.Settings.flgDoEvent)
            Application.DoEvents();
          Thread.Sleep(100);
          Serial_Port.Close();
          this.Trace("Port closed successfully ...........", TermId);
          flag = true;
          Serial_Port.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Close_Port Error : " + ex.Message, TermId);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (!Information.IsNothing((object) Serial_Port))
          Serial_Port.Dispose();
        if (this.Settings.flgDoEvent)
          Application.DoEvents();
        Serial_Port = (SerialPort) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private byte GetLrc(byte[] BPkt, int blen)
    {
      byte lrc;
      try
      {
        lrc = (byte) 0;
        if (blen >= 2)
        {
          int num = checked (blen - 1);
          int index = 1;
          while (index <= num)
          {
            lrc ^= BPkt[index];
            checked { ++index; }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        lrc = (byte) 0;
        ProjectData.ClearProjectError();
      }
      return lrc;
    }

    public bool SaveSettings(
      string PortNo,
      int BaudRate,
      int Timeout,
      int TxnTimeout,
      int UploadTimeout,
      string TracePath,
      bool flgTrace,
      bool Delay,
      int DelayTimeout,
      bool APACS,
      bool WaitMessge,
      bool TxnLog)
    {
      bool flag;
      try
      {
        this.Settings.PortName = PortNo;
        this.Settings.BaudRate = BaudRate;
        this.Settings.Timeout = checked ((short) Timeout);
        this.Settings.TxnTimeout = checked ((short) TxnTimeout);
        this.Settings.UploadTimeout = checked ((short) UploadTimeout);
        this.Settings.TracePath = TracePath;
        this.Settings.Trace = flgTrace;
        this.Settings.Delay = Delay;
        this.Settings.DelayTimeout = checked ((short) DelayTimeout);
        this.Settings.flgAPACS = APACS;
        this.Settings.flgWaitRes = WaitMessge;
        this.Settings.flgTxnLog = TxnLog;
        this.SaveFile(this.Settings);
        this.Trace("GetSettings Success, Port :" + this.Settings.PortName + ",BaudRate :" + this.Settings.BaudRate.ToString() + ",Timeout :" + this.Settings.Timeout.ToString() + ",TxnTimeout :" + this.Settings.TxnTimeout.ToString() + ",UploadTimeout :" + this.Settings.UploadTimeout.ToString() + ",TracePath :" + this.Settings.TracePath + ",Trace :" + this.Settings.Trace.ToString() + ",Delay :" + this.Settings.Delay.ToString() + ",DelayTimeout :" + this.Settings.DelayTimeout.ToString() + ",DCC :" + this.Settings.flgAPACS.ToString() + ",flgWaitRes :" + this.Settings.flgWaitRes.ToString() + ",TxnLog :" + this.Settings.flgTxnLog.ToString());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("Error on SaveSettings : " + exception.Message);
        this.Trace("Error on SaveSettings : " + exception.ToString());
        flag = false;
        ProjectData.ClearProjectError();
        goto label_3;
      }
      flag = true;
label_3:
      return flag;
    }

    public bool GetSettings(
      ref string PortNo,
      ref int BaudRate,
      ref short Timeout,
      ref int TxnTimeout,
      ref int UploadTimeout,
      ref string TracePath,
      ref bool flgTrace,
      ref bool Delay,
      ref short DelayTimeout,
      ref bool DCC,
      ref bool WaitMessge,
      ref bool TxnLog)
    {
      bool settings;
      try
      {
        PortNo = this.Settings.PortName;
        BaudRate = this.Settings.BaudRate;
        Timeout = this.Settings.Timeout;
        TxnTimeout = (int) this.Settings.TxnTimeout;
        UploadTimeout = (int) this.Settings.UploadTimeout;
        TracePath = this.Settings.TracePath;
        flgTrace = this.Settings.Trace;
        Delay = this.Settings.Delay;
        DelayTimeout = this.Settings.DelayTimeout;
        DCC = this.Settings.flgAPACS;
        WaitMessge = this.Settings.flgWaitRes;
        TxnLog = this.Settings.flgTxnLog;
        this.Trace("GetSettings Success, Port :" + this.Settings.PortName + ",BaudRate :" + this.Settings.BaudRate.ToString() + ",Timeout :" + this.Settings.Timeout.ToString() + ",TxnTimeout :" + this.Settings.TxnTimeout.ToString() + ",UploadTimeout :" + this.Settings.UploadTimeout.ToString() + ",TracePath :" + this.Settings.TracePath + ",Trace :" + this.Settings.Trace.ToString() + ",Delay :" + this.Settings.Delay.ToString() + ",DelayTimeout :" + this.Settings.DelayTimeout.ToString() + ",DCC :" + this.Settings.flgAPACS.ToString() + ",flgWaitRes :" + this.Settings.flgWaitRes.ToString() + ",TxnLog :" + this.Settings.flgTxnLog.ToString());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("Error on GetSettings : " + exception.Message);
        this.Trace("Error on GetSettings : " + exception.ToString());
        settings = false;
        ProjectData.ClearProjectError();
        goto label_3;
      }
      settings = true;
label_3:
      return settings;
    }

    private string CalculateMAC(string MacData)
    {
      string mac = "";
      try
      {
        mac = !this.Settings.flgAPACS ? this.CalculateMAC_ISO(MacData) : this.CalculateMAC_APACS(MacData);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return mac;
    }

    private string CalculateMAC_APACS(string MacData, bool flgCal = true)
    {
      string macApacs = "00000000";
      try
      {
        string Keystr = "LALITHAPKARTHIKALALITHAP";
        macApacs = this.TripleDES(!flgCal ? MacData + "99" : MacData + "66", Keystr);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return macApacs;
    }

    private string CalculateMAC_ISO(string MacData, bool flgCal = true)
    {
      string macIso = "00000000";
      byte[] TdesKey = new byte[24]
      {
        (byte) 193,
        (byte) 143,
        (byte) 201,
        (byte) 165,
        (byte) 59,
        (byte) 29,
        (byte) 102,
        (byte) 198,
        (byte) 248,
        (byte) 99,
        (byte) 30,
        (byte) 105,
        (byte) 108,
        (byte) 99,
        (byte) 92,
        (byte) 100,
        (byte) 193,
        (byte) 143,
        (byte) 201,
        (byte) 165,
        (byte) 59,
        (byte) 29,
        (byte) 102,
        (byte) 198
      };
      try
      {
        macIso = this.TripleDES(!flgCal ? MacData + "99" : MacData + "66", TdesKey);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return macIso;
    }

    private bool VerifyMAC(string MacData, string Mac)
    {
      bool flag;
      try
      {
        flag = !this.Settings.flgAPACS ? this.VerifyMAC_ISO(MacData, Mac) : this.VerifyMAC_APACS(MacData, Mac);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("MAC Verify Error: " + Information.Err().Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool VerifyMACInit(string MacData, string Mac)
    {
      bool flag;
      try
      {
        flag = !this.Settings.flgAPACS ? this.VerifyMAC_ISO(MacData, Mac, true) : this.VerifyMAC_APACS(MacData, Mac, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("MAC Verify Error: " + Information.Err().Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool VerifyMAC_APACS(string MacData, string Mac, bool flgInit = false)
    {
      bool flag;
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Mac, "", false) == 0)
        {
          flag = false;
        }
        else
        {
          string Keystr = "LALITHAPKARTHIKALALITHAP";
          string Left = this.TripleDES(!flgInit ? MacData + "66" : MacData + "99", Keystr);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0)
            flag = false;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left.Substring(0, 8), Mac.Trim(), false) != 0)
          {
            this.Trace("MAC(APACS) Verification Failed.");
            this.ClearData();
            flag = false;
          }
          else
            flag = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("MAC Verify Error: " + Information.Err().Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool VerifyMAC_ISO(string MacData, string Mac, bool flgInit = false)
    {
      byte[] TdesKey = new byte[24]
      {
        (byte) 193,
        (byte) 143,
        (byte) 201,
        (byte) 165,
        (byte) 59,
        (byte) 29,
        (byte) 102,
        (byte) 198,
        (byte) 248,
        (byte) 99,
        (byte) 30,
        (byte) 105,
        (byte) 108,
        (byte) 99,
        (byte) 92,
        (byte) 100,
        (byte) 193,
        (byte) 143,
        (byte) 201,
        (byte) 165,
        (byte) 59,
        (byte) 29,
        (byte) 102,
        (byte) 198
      };
      bool flag;
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Mac, "", false) == 0)
        {
          flag = false;
        }
        else
        {
          string Left = this.TripleDES(!flgInit ? MacData + "66" : MacData + "99", TdesKey);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0)
            flag = false;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left.Substring(0, 8), Mac.Trim(), false) != 0)
          {
            this.Trace("MAC Verification Failed.");
            this.ClearData();
            flag = false;
          }
          else
            flag = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("MAC Verify Error: " + Information.Err().Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool Trace(string strmsg, byte[] msg, int Llen)
    {
      bool flag;
      try
      {
        if (!this.Settings.Trace)
        {
          flag = true;
          goto label_5;
        }
        else
        {
          strmsg += this.Byte2ByteStr(msg, (short) 0, checked ((short) Llen));
          flag = this.Trace(strmsg);
          goto label_5;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_5:
      return flag;
    }

    private bool Trace(string strMsg)
    {
      bool flag;
      try
      {
        flag = this.Trace(strMsg, "");
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_3:
      return flag;
    }

    private bool TxnLog(string strMsg)
    {
      StreamWriter streamWriter = (StreamWriter) null;
      bool flag1 = false;
      bool flag2;
      try
      {
        if (!Directory.Exists(this.Settings.TracePath))
          Directory.CreateDirectory(this.Settings.TracePath);
        string path = this.Settings.TracePath + "\\Txn" + DateAndTime.Now.ToString("yyyyMMdd") + ".csv";
        if (!File.Exists(path))
          flag1 = true;
        streamWriter = new StreamWriter(path, true);
        if (flag1)
          streamWriter.WriteLine("VFI_DateTime, VFI_TransType, VFI_ECRRcptNum, VFI_Amount, VFI_CardNum, VFI_Expiry, VFI_CashAmount, VFI_MessNum, VFI_CardSchemeName, VFI_AuthMode, VFI_CHVerification, VFI_ApprovalCode, VFI_TID , VFI_Batch , VFI_ExchRate , VFI_PYCAmount ,  VFI_MarkUp ,    VFI_PYCCurr , VFI_PYCCurrName ,  VFI_OptOut ,  VFI_RespMess");
        streamWriter.WriteLine(strMsg);
        streamWriter.Flush();
        flag2 = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Error on TxnLog : " + ex.Message);
        flag2 = false;
        ProjectData.ClearProjectError();
      }
      try
      {
        if (streamWriter != null)
        {
          streamWriter.Close();
          streamWriter.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return flag2;
    }

    private string TripleDES(string DataStr, string Keystr)
    {
      byte[] numArray1 = new byte[24]
      {
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] rgbIV = new byte[8];
      byte[] numArray2 = new byte[8];
      byte[] numArray3 = new byte[8];
      string str1 = "";
      string str2;
      try
      {
        byte[] bytes = Encoding.ASCII.GetBytes(Keystr);
        if (DataStr.Length % 8 != 0)
        {
          str2 = "";
        }
        else
        {
          byte[] inputBuffer = this.ByteStrToByte(DataStr);
          numArray2 = new byte[checked ((int) (short) DataStr.Length + 1)];
          int num1 = checked (inputBuffer.Length - 1);
          int num2 = 0;
          while (num2 <= num1)
          {
            byte[] outputBuffer = new byte[8];
            cryptoTransform = cryptoServiceProvider.CreateEncryptor(bytes, rgbIV);
            cryptoTransform.TransformBlock(inputBuffer, num2, 8, outputBuffer, num2);
            str1 += BitConverter.ToString(outputBuffer).Replace("-", "");
            checked { num2 += 8; }
          }
          str2 = str1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str2;
    }

    private string TripleDES(string DataStr, byte[] TdesKey)
    {
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] rgbIV = new byte[8];
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[8];
      string str1 = "";
      string str2;
      try
      {
        if (DataStr.Length % 8 != 0)
        {
          str2 = "";
        }
        else
        {
          byte[] inputBuffer = this.ByteStrToByte(DataStr);
          numArray1 = new byte[checked ((int) (short) DataStr.Length + 1)];
          int num1 = checked (inputBuffer.Length - 1);
          int num2 = 0;
          while (num2 <= num1)
          {
            byte[] outputBuffer = new byte[8];
            cryptoTransform = cryptoServiceProvider.CreateEncryptor(TdesKey, rgbIV);
            cryptoTransform.TransformBlock(inputBuffer, num2, 8, outputBuffer, num2);
            str1 += BitConverter.ToString(outputBuffer).Replace("-", "");
            checked { num2 += 8; }
          }
          str2 = str1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str2;
    }

    private string TripleDES(string DataStr)
    {
      byte[] rgbKey = new byte[24]
      {
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] rgbIV = new byte[8];
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[8];
      string str1 = "";
      string str2;
      try
      {
        short length = checked ((short) DataStr.Length);
        if ((int) length % 8 != 0)
          checked { length += unchecked ((short) checked (8 - unchecked ((int) length % 8))); }
        byte[] outputBuffer = new byte[checked ((int) length + 1)];
        int num1 = checked (DataStr.Length - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
          outputBuffer = new byte[8];
          byte[] numArray3 = new byte[8];
          short charCount = checked ((short) (DataStr.Length - num2));
          if (charCount > (short) 8)
            charCount = (short) 8;
          Encoding.ASCII.GetBytes(DataStr, num2, (int) charCount, numArray3, 0);
          cryptoTransform = cryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV);
          cryptoTransform.TransformBlock(numArray3, 0, 8, outputBuffer, num2);
          checked { num2 += 8; }
        }
        str2 = str1 + BitConverter.ToString(outputBuffer).Replace("-", "");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str2;
    }

    private byte[] TripleDES_(string DataStr)
    {
      byte[] rgbKey = new byte[24]
      {
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] rgbIV = new byte[8];
      byte[] outputBuffer = new byte[8];
      byte[] numArray1 = new byte[8];
      byte[] numArray2;
      try
      {
        short length = checked ((short) DataStr.Length);
        if ((int) length % 8 != 0)
          checked { length += unchecked ((short) checked (8 - unchecked ((int) length % 8))); }
        outputBuffer = new byte[checked ((int) length - 1 + 1)];
        int num1 = checked (DataStr.Length - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
          byte[] numArray3 = new byte[8];
          short charCount = checked ((short) (DataStr.Length - num2));
          if (charCount > (short) 8)
            charCount = (short) 8;
          Encoding.ASCII.GetBytes(DataStr, num2, (int) charCount, numArray3, 0);
          cryptoTransform = cryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV);
          cryptoTransform.TransformBlock(numArray3, 0, 8, outputBuffer, num2);
          checked { num2 += 8; }
        }
        numArray2 = outputBuffer;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        numArray2 = outputBuffer;
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return numArray2;
    }

    private string TripleDES(string StrIV, string strData, byte[] Key)
    {
      byte[] numArray1 = new byte[24];
      byte[] numArray2 = new byte[8];
      byte[] numArray3 = new byte[8];
      string str1 = "";
      TripleDESCryptoServiceProvider cryptoServiceProvider1 = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      string str2;
      try
      {
        if (strData.Length != 8)
          str2 = str1;
        else if (StrIV.Length != 8)
        {
          str2 = str1;
        }
        else
        {
          byte[] bytes = Encoding.ASCII.GetBytes(StrIV);
          int length1 = strData.Length;
          if (length1 % 8 != 0)
            checked { length1 += 8 - unchecked (length1 % 8); }
          byte[] numArray4 = new byte[checked (length1 - 1 + 1)];
          Encoding.ASCII.GetBytes(strData, 0, strData.Length, numArray4, 0);
          int length2 = Key.Length;
          if (length2 >= 24)
            Array.Copy((Array) Key, 0, (Array) numArray1, 0, 24);
          else if (length2 > 16 & length2 < 24)
            Array.Copy((Array) Key, 0, (Array) numArray1, 0, Key.Length);
          else if (length2 <= 16 & length2 > 8)
          {
            Array.Copy((Array) Key, 0, (Array) numArray1, 0, Key.Length);
            Array.Copy((Array) Key, 0, (Array) numArray1, 16, 8);
          }
          else if (length2 <= 8 & length2 > 0)
          {
            DESCryptoServiceProvider cryptoServiceProvider2 = new DESCryptoServiceProvider();
            byte[] numArray5 = new byte[8];
            Array.Copy((Array) Key, 0, (Array) numArray5, 0, Key.Length);
            int num = checked (numArray4.Length - 1);
            int inputOffset = 0;
            while (inputOffset <= num)
            {
              byte[] outputBuffer = new byte[8];
              cryptoServiceProvider2.CreateEncryptor(numArray5, bytes).TransformBlock(numArray4, inputOffset, 8, outputBuffer, 0);
              str1 += BitConverter.ToString(outputBuffer).Replace("-", "");
              checked { inputOffset += 8; }
            }
            str2 = str1;
            goto label_27;
          }
          else
          {
            str2 = str1;
            goto label_27;
          }
          int num1 = checked (numArray4.Length - 1);
          int inputOffset1 = 0;
          while (inputOffset1 <= num1)
          {
            byte[] outputBuffer = new byte[8];
            cryptoTransform = cryptoServiceProvider1.CreateEncryptor(numArray1, bytes);
            cryptoTransform.TransformBlock(numArray4, inputOffset1, 8, outputBuffer, 0);
            str1 += BitConverter.ToString(outputBuffer).Replace("-", "");
            checked { inputOffset1 += 8; }
          }
          str2 = str1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        str2 = str1;
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider1.Clear();
      }
label_27:
      return str2;
    }

    private byte[] ByteStrToByte(string str)
    {
      byte[] numArray1 = new byte[checked (unchecked (str.Length / 2) - 1 + 1)];
      byte[] numArray2;
      try
      {
        if (str.Length % 2 != 0)
        {
          numArray2 = (byte[]) null;
        }
        else
        {
          int num = checked (unchecked (str.Length / 2) - 1);
          int index = 0;
          while (index <= num)
          {
            numArray1[index] = Conversions.ToByte("&H" + Strings.Mid(str, checked (index * 2 + 1), 2));
            checked { ++index; }
          }
          numArray2 = numArray1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace(exception.Message);
        this.Trace(exception.ToString());
        numArray2 = (byte[]) null;
        ProjectData.ClearProjectError();
      }
      return numArray2;
    }

    private string ByteToBytestr(byte[] bytes, short index, short Llen)
    {
      string bytestr;
      try
      {
        bytestr = BitConverter.ToString(bytes, (int) index, (int) Llen).Replace("-", "");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace(exception.Message);
        this.Trace(exception.ToString());
        bytestr = (string) null;
        ProjectData.ClearProjectError();
      }
      return bytestr;
    }

    private string Byte2ByteStr(byte[] bytes, short index, short Llen)
    {
      string str;
      try
      {
        str = BitConverter.ToString(bytes, (int) index, (int) Llen).Replace("-", " ");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace(exception.Message);
        this.Trace(exception.ToString());
        str = (string) null;
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private string INV_TripleDES(string DataStr)
    {
      byte[] rgbIV = new byte[8];
      byte[] rgbKey = new byte[24]
      {
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[16];
      byte[] numArray3 = new byte[8];
      string str1 = (string) null;
      string str2;
      try
      {
        if (DataStr.Length % 8 != 0)
        {
          str2 = "";
        }
        else
        {
          byte[] sourceArray = this.ByteStrToByte(DataStr);
          int num = checked (sourceArray.Length - 1);
          int sourceIndex = 0;
          while (sourceIndex <= num)
          {
            byte[] outputBuffer = new byte[8];
            byte[] numArray4 = new byte[16];
            Array.Copy((Array) sourceArray, sourceIndex, (Array) numArray4, 0, 8);
            cryptoTransform = cryptoServiceProvider.CreateDecryptor(rgbKey, rgbIV);
            cryptoTransform.TransformBlock(numArray4, 0, 16, outputBuffer, 0);
            str1 += BitConverter.ToString(outputBuffer).Replace("-", "");
            checked { sourceIndex += 8; }
          }
          str2 = str1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        str2 = (string) null;
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str2;
    }

    private string TripleDESBCD(string BCDDataStr)
    {
      byte[] rgbKey = new byte[24]
      {
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 171,
        (byte) 205,
        (byte) 239,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] rgbIV = new byte[8];
      byte[] outputBuffer = new byte[8];
      byte[] numArray = new byte[8];
      string str1 = "";
      string str2;
      try
      {
        if (BCDDataStr.Length % 8 != 0)
        {
          str2 = "";
        }
        else
        {
          byte[] inputBuffer = this.ByteStrToByte(BCDDataStr);
          cryptoTransform = cryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV);
          cryptoTransform.TransformBlock(inputBuffer, 0, 8, outputBuffer, 0);
          str2 = str1 + BitConverter.ToString(outputBuffer).Replace("-", "");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str2;
    }

    public string VFI_AboutDll()
    {
      string str = "";
      try
      {
        str = "BBK ECR DLL with DCC V 2.0.0.0";
        str = "BBK ECR DLL with DCC V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public void Dispose()
    {
      try
      {
        this.Trace("Finalise");
        this.Close_Port(ref this.Serial_Port, "");
        try
        {
          this.Serial_Port.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          this.Serial_Port.Dispose();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          this.Serial_Port = (SerialPort) null;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.Trace("Finalize");
        // ISSUE: explicit finalizer call
        base.Finalize();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        GC.Collect();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public string GetSet_VFI_ECRRcptNum
    {
      get
      {
        this.LogTrace("Get VFI_ECRRcptNum : " + this.VFI_ECRRcptNum);
        return this.VFI_ECRRcptNum;
      }
      set
      {
        this.VFI_ECRRcptNum = value;
        this.LogTrace("Get VFI_ECRRcptNum : " + this.VFI_ECRRcptNum);
      }
    }

    public string GetSet_VFI_TransType
    {
      get => this.VFI_TransType;
      set => this.VFI_TransType = value;
    }

    public string GetSet_VFI_Amount
    {
      get => this.VFI_Amount;
      set => this.VFI_Amount = value;
    }

    public string GetSet_VFI_CashAmount
    {
      get => this.VFI_CashAmount;
      set => this.VFI_CashAmount = value;
    }

    public string GetSet_VFI_CardNum => this.VFI_CardNum;

    public string GetSet_VFI_Expiry => this.VFI_Expiry;

    public string GetSet_VFI_CHName => this.VFI_CHName;

    public string GetSet_VFI_MessNum
    {
      get => this.VFI_MessNum;
      set => this.VFI_MessNum = value;
    }

    public string GetSet_VFI_CardSchemeName => this.VFI_CardSchemeName;

    public string GetSet_VFI_TransSource => this.VFI_TransSource;

    public string GetSet_VFI_AuthMode => this.VFI_AuthMode;

    public string GetSet_VFI_CHVerification => this.VFI_CHVerification;

    public string GetSet_VFI_RespCode => this.VFI_RespCode;

    public string GetSet_VFI_RespMess => this.VFI_RespMess;

    public string GetSet_VFI_ApprovalCode
    {
      get => this.VFI_ApprovalCode;
      set => this.VFI_ApprovalCode = value;
    }

    public string GetSet_VFI_DateTime => this.VFI_DateTime;

    public string GetSet_VFI_EMV_Label => this.VFI_EMV_Label;

    public string GetSet_VFI_EMV_AID => this.VFI_EMV_AID;

    public string GetSet_VFI_EMV_TVR => this.VFI_EMV_TVR;

    public string GetSet_VFI_EMV_TSI => this.VFI_EMV_TSI;

    public string GetSet_VFI_EMV_AC => this.VFI_EMV_AC;

    public string GetSet_VFI_VoidReceiptNum
    {
      get => this.VFI_VoidReceiptNum;
      set => this.VFI_VoidReceiptNum = value;
    }

    public string GetSet_VFI_DBCount => this.VFI_DBCount;

    public string GetSet_VFI_DBAmount => this.VFI_DBAmount;

    public string GetSet_VFI_CRCount => this.VFI_CRCount;

    public string GetSet_VFI_CRAmount => this.VFI_CRAmount;

    public string GetSet_VFI_PYCDBCount => this.VFI_PYCDBCount;

    public string GetSet_VFI_PYCDBAmount => this.VFI_PYCDBAmount;

    public string GetSet_VFI_PYCCRCount => this.VFI_PYCCRCount;

    public string GetSet_VFI_PYCCRAmount => this.VFI_PYCCRAmount;

    public string GetSet_VFI_LHDBCount => this.VFI_LHDBCount;

    public string GetSet_VFI_LHDBAmount => this.VFI_LHDBAmount;

    public string GetSet_VFI_LHCRCount => this.VFI_LHCRCount;

    public string GetSet_VFI_LHCRAmount => this.VFI_LHCRAmount;

    public string GetSet_VFI_AdditionalInfo
    {
      get => this.VFI_AdditionalInfo;
      set => this.VFI_AdditionalInfo = value;
    }

    public string GetSet_VFI_TID
    {
      get => this.VFI_TID;
      set => this.VFI_TID = value;
    }

    public string GetSet_VFI_MID
    {
      get => this.VFI_MID;
      set => this.VFI_MID = value;
    }

    public string GetSet_VFI_Batch => this.VFI_Batch;

    public string GetSet_VFI_EMVCID => this.VFI_EMVCID;

    public string GetSet_VFI_ExchRate => this.VFI_ExchRate;

    public string GetSet_VFI_PYCAmount => this.VFI_PYCAmount;

    public string GetSet_VFI_MarkUp => this.VFI_MarkUp;

    public string GetSet_VFI_PYCCurr => this.VFI_PYCCurr;

    public string GetSet_VFI_PYCCurrName => this.VFI_PYCCurrName;

    public string GetSet_VFI_OptOut
    {
      get => this.VFI_OptOut;
      set => this.VFI_OptOut = value;
    }

    public string GetSet_CurrentInstruction
    {
      get
      {
        this.LogTrace("Get strCurrentInstruction : " + comCMXECR.strInstruction);
        return comCMXECR.strInstruction;
      }
    }

    private string Set_CurrentInstruction
    {
      set
      {
        comCMXECR.strInstruction = value;
        this.LogTrace("Set strCurrentInstruction : " + comCMXECR.strInstruction);
        comCMXECR.getPOSCurrentInstructionEventHandler instructionEvent = this.getPOSCurrentInstructionEvent;
        if (instructionEvent == null)
          return;
        instructionEvent(comCMXECR.strInstruction);
      }
    }

    public string GetSet_VFI_Card_First7
    {
      get => this.VFI_Card_First7;
      set => this.VFI_Card_First7 = value;
    }

    public string GetSet_VFI_Card_last4
    {
      get => this.VFI_Card_Last4;
      set => this.VFI_Card_Last4 = value;
    }

    private bool LogTrace(string strMsg)
    {
      try
      {
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Error on LogTrace : " + ex.Message);
        ProjectData.ClearProjectError();
      }
      return false;
    }

    public string GetSet_VFI_CardTypes => Conversions.ToString(this.VFI_CardTypes);

    public string GetSet_VFI_DccCardTypes => Conversions.ToString(this.VFI_DccCardTypes);

    public string GetSet_VFI_CardType0_CardName => this.VFI_CardType0_CardName;

    public string GetSet_VFI_CardType0_DBCount => this.VFI_CardType0_DBCount;

    public string GetSet_VFI_CardType0_DBAmount => this.VFI_CardType0_DBAmount;

    public string GetSet_VFI_CardType0_CRCount => this.VFI_CardType0_CRCount;

    public string GetSet_VFI_CardType0_CRAmount => this.VFI_CardType0_CRAmount;

    public string GetSet_VFI_CardType1_CardName => this.VFI_CardType1_CardName;

    public string GetSet_VFI_CardType1_DBCount => this.VFI_CardType1_DBCount;

    public string GetSet_VFI_CardType1_DBAmount => this.VFI_CardType1_DBAmount;

    public string GetSet_VFI_CardType1_CRCount => this.VFI_CardType1_CRCount;

    public string GetSet_VFI_CardType1_CRAmount => this.VFI_CardType1_CRAmount;

    public string GetSet_VFI_CardType2_CardName => this.VFI_CardType2_CardName;

    public string GetSet_VFI_CardType2_DBCount => this.VFI_CardType2_DBCount;

    public string GetSet_VFI_CardType2_DBAmount => this.VFI_CardType2_DBAmount;

    public string GetSet_VFI_CardType2_CRCount => this.VFI_CardType2_CRCount;

    public string GetSet_VFI_CardType2_CRAmount => this.VFI_CardType2_CRAmount;

    public string GetSet_VFI_CardType3_CardName => this.VFI_CardType3_CardName;

    public string GetSet_VFI_CardType3_DBCount => this.VFI_CardType3_DBCount;

    public string GetSet_VFI_CardType3_DBAmount => this.VFI_CardType3_DBAmount;

    public string GetSet_VFI_CardType3_CRCount => this.VFI_CardType3_CRCount;

    public string GetSet_VFI_CardType3_CRAmount => this.VFI_CardType3_CRAmount;

    public string GetSet_VFI_CardType4_CardName => this.VFI_CardType4_CardName;

    public string GetSet_VFI_CardType4_DBCount => this.VFI_CardType4_DBCount;

    public string GetSet_VFI_CardType4_DBAmount => this.VFI_CardType4_DBAmount;

    public string GetSet_VFI_CardType4_CRCount => this.VFI_CardType4_CRCount;

    public string GetSet_VFI_CardType4_CRAmount => this.VFI_CardType4_CRAmount;

    public string GetSet_VFI_CardType5_CardName => this.VFI_CardType5_CardName;

    public string GetSet_VFI_CardType5_DBCount => this.VFI_CardType5_DBCount;

    public string GetSet_VFI_CardType5_DBAmount => this.VFI_CardType5_DBAmount;

    public string GetSet_VFI_CardType5_CRCount => this.VFI_CardType5_CRCount;

    public string GetSet_VFI_CardType5_CRAmount => this.VFI_CardType5_CRAmount;

    public string GetSet_VFI_CardType6_CardName => this.VFI_CardType6_CardName;

    public string GetSet_VFI_CardType6_DBCount => this.VFI_CardType6_DBCount;

    public string GetSet_VFI_CardType6_DBAmount => this.VFI_CardType6_DBAmount;

    public string GetSet_VFI_CardType6_CRCount => this.VFI_CardType6_CRCount;

    public string GetSet_VFI_CardType6_CRAmount => this.VFI_CardType6_CRAmount;

    public string GetSet_VFI_CardType7_CardName => this.VFI_CardType7_CardName;

    public string GetSet_VFI_CardType7_DBCount => this.VFI_CardType7_DBCount;

    public string GetSet_VFI_CardType7_DBAmount => this.VFI_CardType7_DBAmount;

    public string GetSet_VFI_CardType7_CRCount => this.VFI_CardType7_CRCount;

    public string GetSet_VFI_CardType7_CRAmount => this.VFI_CardType7_CRAmount;

    public string GetSet_VFI_CardType8_CardName => this.VFI_CardType8_CardName;

    public string GetSet_VFI_CardType8_DBCount => this.VFI_CardType8_DBCount;

    public string GetSet_VFI_CardType8_DBAmount => this.VFI_CardType8_DBAmount;

    public string GetSet_VFI_CardType8_CRCount => this.VFI_CardType8_CRCount;

    public string GetSet_VFI_CardType8_CRAmount => this.VFI_CardType8_CRAmount;

    public string GetSet_VFI_CardType9_CardName => this.VFI_CardType9_CardName;

    public string GetSet_VFI_CardType9_DBCount => this.VFI_CardType9_DBCount;

    public string GetSet_VFI_CardType9_DBAmount => this.VFI_CardType9_DBAmount;

    public string GetSet_VFI_CardType9_CRCount => this.VFI_CardType9_CRCount;

    public string GetSet_VFI_CardType9_CRAmount => this.VFI_CardType9_CRAmount;

    public string GetSet_VFI_DccCardType0_CardName => this.VFI_DccCardType0_CardName;

    public string GetSet_VFI_DccCardType0_DBCount => this.VFI_DccCardType0_DBCount;

    public string GetSet_VFI_DccCardType0_DBAmount => this.VFI_DccCardType0_DBAmount;

    public string GetSet_VFI_DccCardType0_CRCount => this.VFI_DccCardType0_CRCount;

    public string GetSet_VFI_DccCardType0_CRAmount => this.VFI_DccCardType0_CRAmount;

    public string GetSet_VFI_DccCardType1_CardName => this.VFI_DccCardType1_CardName;

    public string GetSet_VFI_DccCardType1_DBCount => this.VFI_DccCardType1_DBCount;

    public string GetSet_VFI_DccCardType1_DBAmount => this.VFI_DccCardType1_DBAmount;

    public string GetSet_VFI_DccCardType1_CRCount => this.VFI_DccCardType1_CRCount;

    public string GetSet_VFI_DccCardType1_CRAmount => this.VFI_DccCardType1_CRAmount;

    public string GetSet_VFI_DccCardType2_CardName => this.VFI_DccCardType2_CardName;

    public string GetSet_VFI_DccCardType2_DBCount => this.VFI_DccCardType2_DBCount;

    public string GetSet_VFI_DccCardType2_DBAmount => this.VFI_DccCardType2_DBAmount;

    public string GetSet_VFI_DccCardType2_CRCount => this.VFI_DccCardType2_CRCount;

    public string GetSet_VFI_DccCardType2_CRAmount => this.VFI_DccCardType2_CRAmount;

    public string GetSet_VFI_DccCardType3_CardName => this.VFI_DccCardType3_CardName;

    public string GetSet_VFI_DccCardType3_DBCount => this.VFI_DccCardType3_DBCount;

    public string GetSet_VFI_DccCardType3_DBAmount => this.VFI_DccCardType3_DBAmount;

    public string GetSet_VFI_DccCardType3_CRCount => this.VFI_DccCardType3_CRCount;

    public string GetSet_VFI_DccCardType3_CRAmount => this.VFI_DccCardType3_CRAmount;

    public string GetSet_VFI_DccCardType4_CardName => this.VFI_DccCardType4_CardName;

    public string GetSet_VFI_DccCardType4_DBCount => this.VFI_DccCardType4_DBCount;

    public string GetSet_VFI_DccCardType4_DBAmount => this.VFI_DccCardType4_DBAmount;

    public string GetSet_VFI_DccCardType4_CRCount => this.VFI_DccCardType4_CRCount;

    public string GetSet_VFI_DccCardType4_CRAmount => this.VFI_DccCardType4_CRAmount;

    public string GetSet_VFI_DccCardType5_CardName => this.VFI_DccCardType5_CardName;

    public string GetSet_VFI_DccCardType5_DBCount => this.VFI_DccCardType5_DBCount;

    public string GetSet_VFI_DccCardType5_DBAmount => this.VFI_DccCardType5_DBAmount;

    public string GetSet_VFI_DccCardType5_CRCount => this.VFI_DccCardType5_CRCount;

    public string GetSet_VFI_DccCardType5_CRAmount => this.VFI_DccCardType5_CRAmount;

    public string GetSet_VFI_DccCardType6_CardName => this.VFI_DccCardType6_CardName;

    public string GetSet_VFI_DccCardType6_DBCount => this.VFI_DccCardType6_DBCount;

    public string GetSet_VFI_DccCardType6_DBAmount => this.VFI_DccCardType6_DBAmount;

    public string GetSet_VFI_DccCardType6_CRCount => this.VFI_DccCardType6_CRCount;

    public string GetSet_VFI_DccCardType6_CRAmount => this.VFI_DccCardType6_CRAmount;

    public string GetSet_VFI_DccCardType7_CardName => this.VFI_DccCardType7_CardName;

    public string GetSet_VFI_DccCardType7_DBCount => this.VFI_DccCardType7_DBCount;

    public string GetSet_VFI_DccCardType7_DBAmount => this.VFI_DccCardType7_DBAmount;

    public string GetSet_VFI_DccCardType7_CRCount => this.VFI_DccCardType7_CRCount;

    public string GetSet_VFI_DccCardType7_CRAmount => this.VFI_DccCardType7_CRAmount;

    public string GetSet_VFI_DccCardType8_CardName => this.VFI_DccCardType8_CardName;

    public string GetSet_VFI_DccCardType8_DBCount => this.VFI_DccCardType8_DBCount;

    public string GetSet_VFI_DccCardType8_DBAmount => this.VFI_DccCardType8_DBAmount;

    public string GetSet_VFI_DccCardType8_CRCount => this.VFI_DccCardType8_CRCount;

    public string GetSet_VFI_DccCardType8_CRAmount => this.VFI_DccCardType8_CRAmount;

    public string GetSet_VFI_DccCardType9_CardName => this.VFI_DccCardType9_CardName;

    public string GetSet_VFI_DccCardType9_DBCount => this.VFI_DccCardType9_DBCount;

    public string GetSet_VFI_DccCardType9_DBAmount => this.VFI_DccCardType9_DBAmount;

    public string GetSet_VFI_DccCardType9_CRCount => this.VFI_DccCardType9_CRCount;

    public string GetSet_VFI_DccCardType9_CRAmount => this.VFI_DccCardType9_CRAmount;

    public string GetSet_VFI_RRN
    {
      get => this.VFI_RRN;
      set => this.VFI_RRN = value;
    }

    public string GetSet_VFI_XmlRespData => this.VFI_XmlRespData;

    public string GetSet_VFI_MerchantName
    {
      get
      {
        this.LogTrace("Get VFI_MerchantName : " + this.VFI_MerchantName);
        return this.VFI_MerchantName;
      }
    }

    public string GetSet_VFI_Address1
    {
      get
      {
        this.LogTrace("Get VFI_Address1 : " + this.VFI_Address1);
        return this.VFI_Address1;
      }
    }

    public string GetSet_VFI_Address2
    {
      get
      {
        this.LogTrace("Get VFI_Address2 : " + this.VFI_Address2);
        return this.VFI_Address2;
      }
    }

    public string GetSet_VFI_Address3
    {
      get
      {
        this.LogTrace("Get VFI_Address3 : " + this.VFI_Address3);
        return this.VFI_Address3;
      }
    }

    public string GetSet_VFI_POSApplicationVersion
    {
      get
      {
        this.LogTrace("Get VFI_POSApplicationVersion : " + this.VFI_POSApplicationVersion);
        return this.VFI_POSApplicationVersion;
      }
    }

    public string GetSet_VFI_AddInInfo1
    {
      get => this.VFI_AddInInfo1;
      set => this.VFI_AddInInfo1 = value;
    }

    public string GetSet_VFI_AddInInfo2
    {
      get => this.VFI_AddInInfo2;
      set => this.VFI_AddInInfo2 = value;
    }

    public string GetSet_VFI_AddInInfo3
    {
      get => this.VFI_AddInInfo3;
      set => this.VFI_AddInInfo3 = value;
    }

    public string GetSet_VFI_AddInInfo4
    {
      get => this.VFI_AddInInfo4;
      set => this.VFI_AddInInfo4 = value;
    }

    public string GetSet_VFI_AddInInfo5
    {
      get => this.VFI_AddInInfo5;
      set => this.VFI_AddInInfo5 = value;
    }

    public string GetSet_VFI_AddInfo1 => this.VFI_AddInfo1;

    public string GetSet_VFI_AddInfo2 => this.VFI_AddInfo2;

    public string GetSet_VFI_AddInfo3 => this.VFI_AddInfo3;

    public string GetSet_VFI_AddInfo4 => this.VFI_AddInfo4;

    public string GetSet_VFI_AddInfo5 => this.VFI_AddInfo5;

    public string GetSet_VFI_AddInfo6 => this.VFI_AddInfo6;

    public string GetSet_VFI_AddInfo7 => this.VFI_AddInfo7;

    public string GetSet_VFI_AddInfo8 => this.VFI_AddInfo8;

    public string GetSet_VFI_AddInfo9 => this.VFI_AddInfo9;

    public string GetSet_VFI_AddInfo10 => this.VFI_AddInfo10;

    public string GetSet_VFI_ReportType
    {
      get => this.VFI_ReportType;
      set => this.VFI_ReportType = value;
    }

    public string GetSet_VFI_BalanceAmount => this.VFI_BalanceAmount;

    private clsDataFields VFI_PIE_Purchase(clsDataFields clsMem, bool flgXml)
    {
      string str = "01";
      string strMsgType = "H";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        this.Trace("VFI_Purchase starts.", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = "System Error";
        if (!this.ValidateLicense())
        {
          this.VFI_RespCode = "99";
          this.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + this.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings())
            {
              this.flgSysConfig = true;
            }
            else
            {
              this.VFI_RespCode = "99";
              this.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + this.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_27;
            }
          }
          if (!this.ValidateTid(ref clsMem.VFI_TID))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Terminal Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_Purchase error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateAmount(ref clsMem.VFI_Amount))
          {
            clsMem.VFI_RespCode = "Z4";
            clsMem.VFI_RespMess = "Zero Amount not allowed";
            this.SetError(ref clsMem);
            this.Trace("VFI_Purchase error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateECRRcptNum(ref clsMem.VFI_ECRRcptNum))
          {
            clsMem.VFI_RespCode = "Z5";
            clsMem.VFI_RespMess = "ECR Receipt Number is must";
            this.SetError(ref clsMem);
            this.Trace("VFI_Purchase error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateTid(ref clsMem.VFI_MID, 15))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Merchant Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_Purchase error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else
          {
            this.Serial_Port = new SerialPort();
            if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
            {
              clsMem.VFI_RespCode = "Z6";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
                clsMem.VFI_RespMess = "Port Error";
              this.Trace("VFI_Purchase Connect Error.", clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
            }
            else if (!this.VFI_InitTxn(ref this.Serial_Port, ref clsMem))
            {
              clsMem.FunctionStatus = false;
            }
            else
            {
              string[] strArray = new string[12]
              {
                strMsgType,
                ",",
                str,
                ",",
                clsMem.VFI_Amount,
                ",",
                clsMem.VFI_ECRRcptNum,
                ",",
                clsMem.VFI_TID,
                ",",
                clsMem.VFI_MID,
                ",{0},{1},"
              };
              clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, string.Concat(strArray), ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
            }
            if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
              this.Trace("VFI_Purchase disconnect Error.", clsMem.VFI_PTID);
            this.Trace("VFI_Purchase success.", clsMem.VFI_PTID);
            comCMXECR.strInstruction = "";
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.VFI_RespCode = "Z0";
        this.VFI_RespMess = exception.Message;
        this.Trace("VFI_Purchase Err:" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("C", ref clsMem, flgXml);
      }
label_27:
      this.SetResData(clsMem);
      return clsMem;
    }

    public bool VFI_PIE_Purchase()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_Amount = this.VFI_Amount;
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_MID = this.VFI_MID;
        clsMem = this.VFI_PIE_Txn(clsMem, "01", false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    private clsDataFields VFI_PIE_Txn(clsDataFields clsMem, string strTxnType, bool flgXml)
    {
      string strMsgType = "H";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        this.Trace("VFI_PIE_Txn starts.", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = "System Error";
        if (!this.ValidateLicense())
        {
          this.VFI_RespCode = "Z1";
          this.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + this.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings())
            {
              this.flgSysConfig = true;
            }
            else
            {
              this.VFI_RespCode = "Z2";
              this.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + this.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_27;
            }
          }
          if (!this.ValidateTid(ref clsMem.VFI_TID))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Terminal Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Txn error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateAmount(ref clsMem.VFI_Amount))
          {
            clsMem.VFI_RespCode = "Z4";
            clsMem.VFI_RespMess = "Zero Amount not allowed";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Txn error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateECRRcptNum(ref clsMem.VFI_ECRRcptNum))
          {
            clsMem.VFI_RespCode = "Z5";
            clsMem.VFI_RespMess = "ECR Receipt Number is must";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Txn error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateTid(ref clsMem.VFI_MID, 15))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Merchant Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Txn error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else
          {
            this.Serial_Port = new SerialPort();
            if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
            {
              clsMem.VFI_RespCode = "Z6";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
                clsMem.VFI_RespMess = "Port Error";
              this.Trace("VFI_PIE_Txn Connect Error.", clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
            }
            else if (!this.VFI_InitTxn(ref this.Serial_Port, ref clsMem))
            {
              clsMem.FunctionStatus = false;
            }
            else
            {
              string[] strArray = new string[12]
              {
                strMsgType,
                ",",
                strTxnType,
                ",",
                clsMem.VFI_Amount,
                ",",
                clsMem.VFI_ECRRcptNum,
                ",",
                clsMem.VFI_TID,
                ",",
                clsMem.VFI_MID,
                ",{0},{1},"
              };
              clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, string.Concat(strArray), ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
            }
            if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
              this.Trace("VFI_PIE_Txn disconnect Error.", clsMem.VFI_PTID);
            this.Trace("VFI_PIE_Txn success.", clsMem.VFI_PTID);
            comCMXECR.strInstruction = "";
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.VFI_RespCode = "Z0";
        this.VFI_RespMess = exception.Message;
        this.Trace("VFI_PIE_Txn Err:" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("H", ref clsMem, flgXml);
      }
label_27:
      this.SetResData(clsMem);
      return clsMem;
    }

    public bool VFI_PIE_Refund()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_Amount = this.VFI_Amount;
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_MID = this.VFI_MID;
        clsMem = this.VFI_PIE_Txn(clsMem, "05", false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_PIE_Reissue()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_Amount = this.VFI_Amount;
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_MID = this.VFI_MID;
        clsMem = this.VFI_PIE_Txn(clsMem, "04", false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    private clsDataFields VFI_PIE_Balance(clsDataFields clsMem, bool flgXml)
    {
      string str = "01";
      string strMsgType = "H";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        this.Trace("VFI_PIE_Balance starts.", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = "System Error";
        if (!this.ValidateLicense())
        {
          this.VFI_RespCode = "Z1";
          this.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + this.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings())
            {
              this.flgSysConfig = true;
            }
            else
            {
              this.VFI_RespCode = "Z2";
              this.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + this.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_25;
            }
          }
          if (!this.ValidateTid(ref clsMem.VFI_TID))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Terminal Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Balance error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateECRRcptNum(ref clsMem.VFI_ECRRcptNum))
          {
            clsMem.VFI_RespCode = "Z5";
            clsMem.VFI_RespMess = "ECR Receipt Number is must";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Balance error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateTid(ref clsMem.VFI_MID, 15))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Merchant Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Balance error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else
          {
            this.Serial_Port = new SerialPort();
            if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
            {
              clsMem.VFI_RespCode = "Z6";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
                clsMem.VFI_RespMess = "Port Error";
              this.Trace("VFI_PIE_Balance Connect Error.", clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
            }
            else if (!this.VFI_InitTxn(ref this.Serial_Port, ref clsMem))
            {
              clsMem.FunctionStatus = false;
            }
            else
            {
              string[] strArray = new string[10]
              {
                strMsgType,
                ",",
                str,
                ",",
                clsMem.VFI_ECRRcptNum,
                ",",
                clsMem.VFI_TID,
                ",",
                clsMem.VFI_MID,
                ",{0},{1},"
              };
              clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, string.Concat(strArray), ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
            }
            if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
              this.Trace("VFI_PIE_Balance disconnect Error.", clsMem.VFI_PTID);
            this.Trace("VFI_PIE_Balance success.", clsMem.VFI_PTID);
            comCMXECR.strInstruction = "";
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.VFI_RespCode = "Z0";
        this.VFI_RespMess = exception.Message;
        this.Trace("VFI_PIE_Balance Err:" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("H", ref clsMem, flgXml);
      }
label_25:
      this.SetResData(clsMem);
      return clsMem;
    }

    public bool VFI_PIE_Balance()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_MID = this.VFI_MID;
        clsMem = this.VFI_PIE_Balance(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    private clsDataFields VFI_PIE_Void(clsDataFields clsMem, bool flgXml)
    {
      string str = "02";
      string strMsgType = "H";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        this.Trace("VFI_PIE_Void starts.", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = "System Error";
        if (!this.ValidateLicense())
        {
          this.VFI_RespCode = "Z1";
          this.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + this.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings())
            {
              this.flgSysConfig = true;
            }
            else
            {
              this.VFI_RespCode = "Z2";
              this.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + this.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_25;
            }
          }
          if (!this.ValidateTid(ref clsMem.VFI_TID))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Terminal Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Void error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateECRRcptNum(ref clsMem.VFI_ECRRcptNum))
          {
            clsMem.VFI_RespCode = "Z5";
            clsMem.VFI_RespMess = "ECR Receipt Number is must";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Void error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateTid(ref clsMem.VFI_MID, 15))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Merchant Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Void error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else
          {
            this.Serial_Port = new SerialPort();
            if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
            {
              clsMem.VFI_RespCode = "Z6";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
                clsMem.VFI_RespMess = "Port Error";
              this.Trace("VFI_PIE_Void Connect Error.", clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
            }
            else if (!this.VFI_InitTxn(ref this.Serial_Port, ref clsMem))
            {
              clsMem.FunctionStatus = false;
            }
            else
            {
              string[] strArray = new string[14]
              {
                strMsgType,
                ",",
                str,
                ",",
                clsMem.VFI_VoidReceiptNum,
                ",",
                clsMem.VFI_Amount,
                ",",
                clsMem.VFI_ECRRcptNum,
                ",",
                clsMem.VFI_TID,
                ",",
                clsMem.VFI_MID,
                ",{0},{1},"
              };
              clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, string.Concat(strArray), ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
            }
            if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
              this.Trace("VFI_PIE_Void disconnect Error.", clsMem.VFI_PTID);
            this.Trace("VFI_PIE_Void success.", clsMem.VFI_PTID);
            comCMXECR.strInstruction = "";
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.VFI_RespCode = "Z0";
        this.VFI_RespMess = exception.Message;
        this.Trace("VFI_PIE_Void Err:" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("H", ref clsMem, flgXml);
      }
label_25:
      this.SetResData(clsMem);
      return clsMem;
    }

    public bool VFI_PIE_Void()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_Amount = this.VFI_Amount;
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_MID = this.VFI_MID;
        clsMem.VFI_VoidReceiptNum = this.VFI_VoidReceiptNum;
        clsMem = this.VFI_PIE_Void(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    private clsDataFields VFI_PIE_Last5Txn(clsDataFields clsMem, bool flgXml)
    {
      string str = "06";
      string strMsgType = "H";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        this.Trace("VFI_PIE_Last5Txn starts.", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = "System Error";
        if (!this.ValidateLicense())
        {
          this.VFI_RespCode = "Z1";
          this.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + this.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings())
            {
              this.flgSysConfig = true;
            }
            else
            {
              this.VFI_RespCode = "Z2";
              this.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + this.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_25;
            }
          }
          if (!this.ValidateTid(ref clsMem.VFI_TID))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Terminal Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Last5Txn error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateECRRcptNum(ref clsMem.VFI_ECRRcptNum))
          {
            clsMem.VFI_RespCode = "Z5";
            clsMem.VFI_RespMess = "ECR Receipt Number is must";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Last5Txn error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else if (!this.ValidateTid(ref clsMem.VFI_MID, 15))
          {
            clsMem.VFI_RespCode = "Z3";
            clsMem.VFI_RespMess = "Merchant Number Missing";
            this.SetError(ref clsMem);
            this.Trace("VFI_PIE_Last5Txn error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else
          {
            this.Serial_Port = new SerialPort();
            if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
            {
              clsMem.VFI_RespCode = "Z6";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
                clsMem.VFI_RespMess = "Port Error";
              this.Trace("VFI_PIE_Last5Txn Connect Error.", clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
            }
            else if (!this.VFI_InitTxn(ref this.Serial_Port, ref clsMem))
            {
              clsMem.FunctionStatus = false;
            }
            else
            {
              string[] strArray = new string[8]
              {
                strMsgType,
                ",",
                str,
                ",",
                clsMem.VFI_TID,
                ",",
                clsMem.VFI_MID,
                ",{0},{1},"
              };
              clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, string.Concat(strArray), ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
            }
            if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
              this.Trace("VFI_PIE_Last5Txn disconnect Error.", clsMem.VFI_PTID);
            this.Trace("VFI_PIE_Last5Txn success.", clsMem.VFI_PTID);
            comCMXECR.strInstruction = "";
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.VFI_RespCode = "Z0";
        this.VFI_RespMess = exception.Message;
        this.Trace("VFI_PIE_Last5Txn Err:" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("C", ref clsMem, flgXml);
      }
label_25:
      this.SetResData(clsMem);
      return clsMem;
    }

    public bool VFI_PIE_Last5Txn()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_MID = this.VFI_MID;
        clsMem = this.VFI_PIE_Last5Txn(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    private bool ProcessPIE(string[] TFields, ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        string tfield = TFields[1];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tfield, "01", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tfield, "05", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tfield, "03", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tfield, "02", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tfield, "06", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tfield, "04", false) == 0)
                {
                  int index1 = 2;
                  clsMem.VFI_RespCode = TFields[index1];
                  int index2 = checked (index1 + 1);
                  clsMem.VFI_RespMess = TFields[index2];
                  int index3 = checked (index2 + 1);
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_ECRRcptNum = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_Amount = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_TID = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_MID = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_CardNum = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_MessNum = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_ApprovalCode = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_BalanceAmount = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_Expiry = TFields[index3];
                    checked { ++index3; }
                  }
                  if (TFields.Length > index3)
                  {
                    clsMem.VFI_DateTime = TFields[index3];
                    checked { ++index3; }
                  }
                  if (this.VerifyMAC(clsMem.VFI_DateTime, TFields[index3], false))
                  {
                    if (this.flgEnc)
                      this.Trace(string.Format("PIE RI MID:{0},TID:{1},Date:{2},Amount:{3},AuthCode:{4},CardNo:{5},ReceiptNo:{6},ResCode:{7},Message:{8},ECRRcptNo:{9},BalanceAmount:{10},Expiry{11}", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_DateTime, (object) clsMem.VFI_Amount, (object) clsMem.VFI_ApprovalCode, (object) "", (object) clsMem.VFI_MessNum, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_ECRRcptNum, (object) clsMem.VFI_BalanceAmount, (object) clsMem.VFI_Expiry));
                  }
                  else
                    goto label_109;
                }
              }
              else
              {
                int index4 = 2;
                clsMem.VFI_RespCode = TFields[index4];
                int index5 = checked (index4 + 1);
                clsMem.VFI_RespMess = TFields[index5];
                int index6 = checked (index5 + 1);
                if (TFields.Length > index6)
                {
                  clsMem.VFI_ECRRcptNum = TFields[index6];
                  checked { ++index6; }
                }
                if (TFields.Length > index6)
                {
                  clsMem.VFI_TID = TFields[index6];
                  checked { ++index6; }
                }
                if (TFields.Length > index6)
                {
                  clsMem.VFI_MID = TFields[index6];
                  checked { ++index6; }
                }
                if (TFields.Length > index6)
                {
                  clsMem.VFI_CardNum = TFields[index6];
                  checked { ++index6; }
                }
                if (TFields.Length > index6)
                {
                  clsMem.VFI_MessNum = TFields[index6];
                  checked { ++index6; }
                }
                if (TFields.Length > index6)
                {
                  clsMem.VFI_ApprovalCode = TFields[index6];
                  checked { ++index6; }
                }
                if (TFields.Length > index6)
                {
                  clsMem.VFI_Last5Txn = TFields[index6];
                  checked { ++index6; }
                }
                if (TFields.Length > index6)
                {
                  clsMem.VFI_DateTime = TFields[index6];
                  checked { ++index6; }
                }
                if (this.VerifyMAC(clsMem.VFI_DateTime, TFields[index6], false))
                {
                  if (this.flgEnc)
                    this.Trace(string.Format("PIE R MID:{0},TID:{1},Date:{2},AuthCode:{3},CardNo:{4},ReceiptNo:{5},ResCode:{6},Message:{7},ECRRcptNo:{8},Last5Txn{9}", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_DateTime, (object) clsMem.VFI_ApprovalCode, (object) "", (object) clsMem.VFI_MessNum, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_ECRRcptNum, (object) clsMem.VFI_Last5Txn));
                }
                else
                  goto label_109;
              }
            }
            else
            {
              int index7 = 2;
              clsMem.VFI_RespCode = TFields[index7];
              int index8 = checked (index7 + 1);
              clsMem.VFI_RespMess = TFields[index8];
              int index9 = checked (index8 + 1);
              if (TFields.Length > index9)
              {
                clsMem.VFI_ECRRcptNum = TFields[index9];
                checked { ++index9; }
              }
              if (TFields.Length > index9)
              {
                clsMem.VFI_Amount = TFields[index9];
                checked { ++index9; }
              }
              if (TFields.Length > index9)
              {
                clsMem.VFI_TID = TFields[index9];
                checked { ++index9; }
              }
              if (TFields.Length > index9)
              {
                clsMem.VFI_MID = TFields[index9];
                checked { ++index9; }
              }
              if (TFields.Length > index9)
              {
                clsMem.VFI_CardNum = TFields[index9];
                checked { ++index9; }
              }
              if (TFields.Length > index9)
              {
                clsMem.VFI_MessNum = TFields[index9];
                checked { ++index9; }
              }
              if (TFields.Length > index9)
              {
                clsMem.VFI_ApprovalCode = TFields[index9];
                checked { ++index9; }
              }
              if (TFields.Length > index9)
              {
                clsMem.VFI_DateTime = TFields[index9];
                checked { ++index9; }
              }
              if (this.VerifyMAC(clsMem.VFI_DateTime, TFields[index9], false))
              {
                if (this.flgEnc)
                  this.Trace(string.Format("PIE R MID:{0},TID:{1},Date:{2},Amount:{3},AuthCode:{4},CardNo:{5},ReceiptNo:{6},ResCode:{7},Message:{8},ECRRcptNo:{9}", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_DateTime, (object) clsMem.VFI_Amount, (object) clsMem.VFI_ApprovalCode, (object) "", (object) clsMem.VFI_MessNum, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_ECRRcptNum));
              }
              else
                goto label_109;
            }
          }
          else
          {
            int index10 = 2;
            clsMem.VFI_RespCode = TFields[index10];
            int index11 = checked (index10 + 1);
            clsMem.VFI_RespMess = TFields[index11];
            int index12 = checked (index11 + 1);
            if (TFields.Length > index12)
            {
              clsMem.VFI_ECRRcptNum = TFields[index12];
              checked { ++index12; }
            }
            if (TFields.Length > index12)
            {
              clsMem.VFI_Amount = TFields[index12];
              checked { ++index12; }
            }
            if (TFields.Length > index12)
            {
              clsMem.VFI_TID = TFields[index12];
              checked { ++index12; }
            }
            if (TFields.Length > index12)
            {
              clsMem.VFI_MID = TFields[index12];
              checked { ++index12; }
            }
            if (TFields.Length > index12)
            {
              clsMem.VFI_CardNum = TFields[index12];
              checked { ++index12; }
            }
            if (TFields.Length > index12)
            {
              clsMem.VFI_MessNum = TFields[index12];
              checked { ++index12; }
            }
            if (TFields.Length > index12)
            {
              clsMem.VFI_ApprovalCode = TFields[index12];
              checked { ++index12; }
            }
            if (TFields.Length > index12)
            {
              clsMem.VFI_BalanceAmount = TFields[index12];
              checked { ++index12; }
            }
            if (TFields.Length > index12)
            {
              clsMem.VFI_DateTime = TFields[index12];
              checked { ++index12; }
            }
            if (this.VerifyMAC(clsMem.VFI_DateTime, TFields[index12], false))
            {
              if (this.flgEnc)
                this.Trace(string.Format("PIE B MID:{0},TID:{1},Date:{2},Amount:{3},AuthCode:{4},CardNo:{5},ReceiptNo:{6},ResCode:{7},Message:{8},ECRRcptNo:{9}", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_DateTime, (object) clsMem.VFI_BalanceAmount, (object) clsMem.VFI_ApprovalCode, (object) "", (object) clsMem.VFI_MessNum, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_ECRRcptNum));
            }
            else
              goto label_109;
          }
        }
        else
        {
          int index13 = 2;
          clsMem.VFI_RespCode = TFields[index13];
          int index14 = checked (index13 + 1);
          clsMem.VFI_RespMess = TFields[index14];
          int index15 = checked (index14 + 1);
          if (TFields.Length > index15)
          {
            clsMem.VFI_ECRRcptNum = TFields[index15];
            checked { ++index15; }
          }
          if (TFields.Length > index15)
          {
            clsMem.VFI_Amount = TFields[index15];
            checked { ++index15; }
          }
          if (TFields.Length > index15)
          {
            clsMem.VFI_TID = TFields[index15];
            checked { ++index15; }
          }
          if (TFields.Length > index15)
          {
            clsMem.VFI_MID = TFields[index15];
            checked { ++index15; }
          }
          if (TFields.Length > index15)
          {
            clsMem.VFI_CardNum = TFields[index15];
            checked { ++index15; }
          }
          if (TFields.Length > index15)
          {
            clsMem.VFI_MessNum = TFields[index15];
            checked { ++index15; }
          }
          if (TFields.Length > index15)
          {
            clsMem.VFI_ApprovalCode = TFields[index15];
            checked { ++index15; }
          }
          if (TFields.Length > index15)
          {
            clsMem.VFI_DateTime = TFields[index15];
            checked { ++index15; }
          }
          if (this.VerifyMAC(clsMem.VFI_DateTime, TFields[index15], false))
          {
            if (this.flgEnc)
              this.Trace(string.Format("PIE P MID:{0},TID:{1},Date:{2},Amount:{3},AuthCode:{4},CardNo:{5},ReceiptNo:{6},ResCode:{7},Message:{8},ECRRcptNo:{9}", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_DateTime, (object) clsMem.VFI_Amount, (object) clsMem.VFI_ApprovalCode, (object) "", (object) clsMem.VFI_MessNum, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_ECRRcptNum));
          }
          else
            goto label_109;
        }
        flag = true;
        goto label_110;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "99";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("ProcessPIE Block Err - " + exception.Message);
        ProjectData.ClearProjectError();
      }
label_109:
      flag = false;
label_110:
      return flag;
    }

    private bool VerifyMAC(string MacData, string Mac, bool flgAPACS)
    {
      bool flag;
      try
      {
        flag = !flgAPACS ? this.VerifyMAC_ISO(MacData, Mac) : this.VerifyMAC_APACS(MacData, Mac);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("MAC Verify Error: " + Information.Err().Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private string TripleDESpkt(string DataStr)
    {
      byte[] rgbKey = new byte[24]
      {
        (byte) 89,
        (byte) 73,
        (byte) 117,
        (byte) 249,
        (byte) 51,
        (byte) 212,
        (byte) 158,
        (byte) 202,
        (byte) 100,
        (byte) 44,
        (byte) 165,
        (byte) 191,
        (byte) 2,
        (byte) 107,
        (byte) 5,
        (byte) 151,
        (byte) 89,
        (byte) 73,
        (byte) 117,
        (byte) 249,
        (byte) 51,
        (byte) 212,
        (byte) 158,
        (byte) 202
      };
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      ICryptoTransform cryptoTransform = (ICryptoTransform) null;
      byte[] rgbIV = new byte[8];
      byte[] outputBuffer = new byte[8];
      byte[] numArray1 = new byte[8];
      string str = "";
      try
      {
        short length = checked ((short) DataStr.Length);
        if ((int) length % 8 != 0)
          checked { length += unchecked ((short) checked (8 - unchecked ((int) length % 8))); }
        DataStr = DataStr.PadRight((int) length, ' ');
        int num = checked (DataStr.Length - 1);
        int charIndex = 0;
        while (charIndex <= num)
        {
          byte[] numArray2 = new byte[8];
          short charCount = checked ((short) (DataStr.Length - charIndex));
          if (charCount > (short) 8)
            charCount = (short) 8;
          Encoding.ASCII.GetBytes(DataStr, charIndex, (int) charCount, numArray2, 0);
          cryptoTransform = cryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV);
          cryptoTransform.TransformBlock(numArray2, 0, 8, outputBuffer, 0);
          str += BitConverter.ToString(outputBuffer, 0, 8).Replace("-", "");
          checked { charIndex += 8; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace(ex.Message);
        str = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
        cryptoTransform?.Dispose();
        cryptoServiceProvider.Clear();
      }
      return str;
    }

    private string CalculateMAC(string MacData, bool flgAPACS)
    {
      string mac = "";
      try
      {
        mac = !flgAPACS ? this.CalculateMAC_ISO(MacData) : this.CalculateMAC_APACS(MacData);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return mac;
    }

    private short RxBlock(
      ref SerialPort Serial_port,
      ref byte[] RxPkt,
      ref DateTime dtTimeout,
      ref string RespMess,
      string strMsgType)
    {
      short num1;
      try
      {
        short num2 = 1;
        this.Trace("Rx Block Starts");
        while (num2 < (short) 3)
        {
          short index = 0;
          RxPkt = new byte[4511];
          bool flag1;
          bool flag2;
          while (DateAndTime.DateDiff(DateInterval.Second, dtTimeout, DateAndTime.Now) < 0L)
          {
            Application.DoEvents();
            Thread.Sleep(0);
            if (Serial_port.BytesToRead <= 0)
            {
              Thread.Sleep(10);
            }
            else
            {
              RxPkt[(int) index] = checked ((byte) Serial_port.ReadByte());
              if (RxPkt[(int) index] == (byte) 2 & !flag1)
              {
                flag1 = false;
                flag2 = true;
              }
              if (!flag1)
              {
                if (!flag2)
                  index = (short) 0;
                if (flag2 & RxPkt[(int) index] == (byte) 3)
                {
                  flag1 = true;
                  flag2 = false;
                }
                checked { ++index; }
              }
              else
                break;
            }
          }
          this.Trace("RX : ", RxPkt, (int) index);
          if (DateAndTime.DateDiff(DateInterval.Second, dtTimeout, DateAndTime.Now) >= 0L & index <= (short) 0)
          {
            RespMess = "Timeout / No Response from Device";
            this.Trace("Process Block Err - " + this.VFI_RespMess);
            num1 = (short) 0;
            goto label_31;
          }
          else
          {
            flag1 = false;
            flag2 = false;
            byte lrc = this.GetLrc(RxPkt, (int) index);
            if (index > (short) 2)
              this.strResMsgType = this.GetMsgType(RxPkt, 1, strMsgType.Length);
            if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.strResMsgType, strMsgType, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.strResMsgType, "G", false) == 0) & (int) lrc == (int) RxPkt[(int) index])
            {
              Serial_port.Write(this.ACK, 0, 1);
              Thread.Sleep(10);
              Application.DoEvents();
              this.Trace("Rx Block - ACK sent");
              num1 = index;
              goto label_31;
            }
            else
            {
              try
              {
                if (Serial_port.BytesToRead > 0)
                  this.Trace("Junk : " + Serial_port.ReadExisting());
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.strResMsgType, strMsgType, false) != 0)
              {
                this.VFI_RespCode = "99";
                this.VFI_RespMess = "Invalid Response(" + this.strResMsgType + "-" + strMsgType + ") from Device";
                this.Trace("RxBlock Err - " + this.VFI_RespMess);
                goto label_30;
              }
              else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strMsgType, "G", false) == 0)
              {
                this.Trace("LRC Cal :" + lrc.ToString() + "," + Conversions.ToString(RxPkt[(int) index]));
                Serial_port.Write(this.NAK, 0, 1);
                Thread.Sleep(10);
                Application.DoEvents();
                this.Trace("Rx Block - NAK sent");
                dtTimeout = DateAndTime.Now.AddSeconds((double) this.Settings.TxnTimeout);
                checked { ++num2; }
              }
            }
          }
        }
        RespMess = "Timeout / No Response from Device";
        this.Trace("Process Block Err - " + this.VFI_RespMess);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        RespMess = exception.Message;
        this.Trace("Rx Block Err - " + exception.ToString());
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("Rx Block Ends");
      }
label_30:
      num1 = (short) 0;
label_31:
      return num1;
    }

    public event comCMXECR.getPOSCurrentInstructionEventHandler getPOSCurrentInstruction;

    private bool WriteTxn(clsDataFields clsMem)
    {
      bool flag;
      try
      {
        if (!this.Settings.flgTxnLog)
        {
          flag = true;
          goto label_8;
        }
        else if (Conversions.ToInteger(clsMem.VFI_RespCode) <= 0)
        {
          this.TxnLog(clsMem.VFI_DateTime + "," + clsMem.VFI_TransType + "," + clsMem.VFI_ECRRcptNum + "," + clsMem.VFI_Amount + "," + clsMem.VFI_CardNum + "," + clsMem.VFI_Expiry + "," + clsMem.VFI_CashAmount + "," + clsMem.VFI_MessNum + "," + clsMem.VFI_CardSchemeName + "," + clsMem.VFI_AuthMode + "," + clsMem.VFI_CHVerification + "," + clsMem.VFI_ApprovalCode + "," + clsMem.VFI_TID + "," + clsMem.VFI_Batch + "," + clsMem.VFI_ExchRate + "," + clsMem.VFI_PYCAmount + "," + clsMem.VFI_MarkUp + "," + clsMem.VFI_PYCCurr + "," + clsMem.VFI_PYCCurrName + "," + clsMem.VFI_OptOut + "," + clsMem.VFI_RespMess);
          flag = true;
          goto label_8;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "99";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("WriteTxn Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("WriteTxn Completed.", clsMem.VFI_PTID);
      }
      flag = false;
label_8:
      return flag;
    }

    public string VFI_DllVersion() => this.VFI_AboutDll();

    public string getCurrentInstruction()
    {
      string strInstruction;
      try
      {
        strInstruction = comCMXECR.strInstruction;
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("CurrentInstruction Err:" + ex.ToString());
        ProjectData.ClearProjectError();
      }
      strInstruction = comCMXECR.strInstruction;
label_3:
      return strInstruction;
    }

    internal comCMXECR.Setting GetSettings()
    {
      comCMXECR.Setting Settings = new comCMXECR.Setting();
      comCMXECR.Setting settings;
      try
      {
        this.CreateLoadSettings(ref Settings);
        settings = Settings;
        goto label_4;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("GetSettings Error : " + exception.Message);
        this.Trace("GetSettings Error : " + exception.ToString());
        ProjectData.ClearProjectError();
      }
      settings = Settings;
label_4:
      return settings;
    }

    internal bool SaveFile(comCMXECR.Setting Settings)
    {
      DataSet dataSet = new DataSet();
      bool flag;
      try
      {
        string str = this.GetCurrPath() + "\\CredimaxSettings.xml";
        if (!File.Exists(str))
          this.CreateSettingsFile(str);
        int num = (int) dataSet.ReadXml(str);
        try
        {
          foreach (DataRow row in dataSet.Tables[0].Rows)
          {
            row["PortName"] = (object) Settings.PortName;
            row["BaudRate"] = (object) Settings.BaudRate;
            row["Timeout"] = (object) Settings.Timeout;
            row["TxnTimeout"] = (object) Settings.TxnTimeout;
            row["UploadTimeout"] = (object) Settings.UploadTimeout;
            row["TracePath"] = (object) Settings.TracePath;
            row["LICData"] = (object) Settings.LICData;
            row["Trace"] = (object) Settings.Trace;
            row["Delay"] = (object) Settings.Delay;
            row["DelayTimeout"] = (object) Settings.DelayTimeout;
            if (dataSet.Tables[0].Columns.IndexOf("flgAPACS") < 0)
              dataSet.Tables[0].Columns.Add("flgAPACS");
            row["flgAPACS"] = (object) Settings.flgAPACS;
            if (dataSet.Tables[0].Columns.IndexOf("flgWaitRes") < 0)
              dataSet.Tables[0].Columns.Add("flgWaitRes");
            row["flgWaitRes"] = (object) Settings.flgWaitRes;
            if (dataSet.Tables[0].Columns.IndexOf("flgTxnLog") < 0)
              dataSet.Tables[0].Columns.Add("flgTxnLog");
            row["flgTxnLog"] = (object) Settings.flgTxnLog;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        dataSet.WriteXml(str);
        flag = true;
        goto label_19;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num1 = (int) MessageBox.Show(exception.Message, "Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        int num2 = (int) MessageBox.Show(exception.ToString(), "Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_19:
      return flag;
    }

    private void CreateLoadSettings(ref comCMXECR.Setting Settings)
    {
      DataSet dataSet = new DataSet();
      try
      {
        string str = this.GetCurrPath() + "\\CredimaxSettings.xml";
        if (!File.Exists(str))
          this.CreateSettingsFile(str);
        int num = (int) dataSet.ReadXml(str);
        DataRow row = dataSet.Tables[0].Rows[0];
        Settings.PortName = Conversions.ToString(row["PortName"]);
        Settings.BaudRate = Conversions.ToInteger(row["BaudRate"]);
        Settings.Timeout = Conversions.ToShort(row["Timeout"]);
        Settings.TxnTimeout = Conversions.ToShort(row["TxnTimeout"]);
        Settings.UploadTimeout = Conversions.ToShort(row["UploadTimeout"]);
        Settings.TracePath = row["TracePath"].ToString();
        Settings.LICData = row["LICData"].ToString();
        Settings.Trace = Conversions.ToBoolean(row["Trace"].ToString());
        Settings.Delay = Conversions.ToBoolean(row["Delay"].ToString());
        Settings.DelayTimeout = Conversions.ToShort(row["DelayTimeout"]);
        if (dataSet.Tables[0].Columns.IndexOf("flgAPACS") < 0)
        {
          dataSet.Tables[0].Columns.Add("flgAPACS");
          dataSet.Tables[0].Rows[0]["flgAPACS"] = (object) "0";
        }
        Settings.flgAPACS = Conversions.ToBoolean(row["flgAPACS"]);
        if (dataSet.Tables[0].Columns.IndexOf("flgWaitRes") < 0)
        {
          dataSet.Tables[0].Columns.Add("flgWaitRes");
          dataSet.Tables[0].Rows[0]["flgWaitRes"] = (object) "0";
        }
        Settings.flgWaitRes = Conversions.ToBoolean(row["flgWaitRes"]);
        if (dataSet.Tables[0].Columns.IndexOf("flgTxnLog") < 0)
        {
          dataSet.Tables[0].Columns.Add("flgTxnLog");
          dataSet.Tables[0].Rows[0]["flgTxnLog"] = (object) "0";
        }
        Settings.flgTxnLog = Conversions.ToBoolean(row["flgTxnLog"]);
        if (dataSet.Tables[0].Columns.IndexOf("flgDoEvent") < 0)
        {
          dataSet.Tables[0].Columns.Add("flgDoEvent");
          dataSet.Tables[0].Rows[0]["flgDoEvent"] = (object) "0";
        }
        Settings.flgDoEvent = Conversions.ToBoolean(row["flgDoEvent"].ToString());
        if (dataSet.Tables[0].Columns.IndexOf("SleepTime") < 0)
        {
          dataSet.Tables[0].Columns.Add("SleepTime");
          dataSet.Tables[0].Rows[0]["SleepTime"] = (object) "0";
        }
        Settings.SleepTime = (int) Conversions.ToShort(row["SleepTime"].ToString());
        if (dataSet.Tables[0].Columns.IndexOf("DtrRts") < 0)
        {
          dataSet.Tables[0].Columns.Add("DtrRts");
          dataSet.Tables[0].Rows[0]["DtrRts"] = (object) "0";
        }
        Settings.DtrRts = Conversions.ToBoolean(row["DtrRts"].ToString());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num1 = (int) MessageBox.Show(exception.Message, "Load File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        int num2 = (int) MessageBox.Show(exception.ToString(), "Load File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
    }

    private void CreateLoadSettings()
    {
      try
      {
        this.CreateLoadSettings(ref this.Settings);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num1 = (int) MessageBox.Show(exception.Message, "Load File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        int num2 = (int) MessageBox.Show(exception.ToString(), "Load File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
    }

    private bool CreateSettingsFile(string strPath)
    {
      StreamWriter streamWriter = (StreamWriter) null;
      bool settingsFile = false;
      try
      {
        string str = " <NewDataSet>  <Settings>    <PortName>COM1</PortName>    <BaudRate>19200</BaudRate>    <Timeout>10</Timeout>    <TxnTimeout>90</TxnTimeout>    <UploadTimeout>300</UploadTimeout>    <Trace>1</Trace>    <TracePath>C:\\Credimax\\Trace</TracePath>    <Delay>0</Delay>    <DelayTimeout>5</DelayTimeout>    <LICData>15CEB6E991F3279E</LICData>    <flgAPACS>0</flgAPACS>    <flgWaitRes>0</flgWaitRes>  <flgTxnLog>0</flgTxnLog>   <flgDoEvent>0</flgDoEvent> <SleepTime>10</SleepTime> </Settings></NewDataSet>";
        streamWriter = new StreamWriter(strPath, false);
        streamWriter.Write(str);
        streamWriter.Flush();
        streamWriter.Close();
        settingsFile = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        streamWriter?.Dispose();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return settingsFile;
    }

    private clsDataFields VFI_GetAuth(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "C";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        this.Trace("VFI_GetAuth starts.", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = "System Error";
        if (!this.ValidateLicense(ref this.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
            clsMem.VFI_RespMess = "Error on Load lic";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          this.LicVerified = true;
          clsMem.VFI_RespMess = "System Error";
          if (this.LoadSettings(clsMem.VFI_TID))
          {
            this.flgSysConfig = true;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_TransType, "", false) == 0)
              clsMem.VFI_TransType = "01";
            clsMem.VFI_TransType = clsMem.VFI_TransType.TrimEnd('0');
            clsMem.VFI_TransType = clsMem.VFI_TransType.Trim();
            if (clsMem.VFI_TransType.Length <= 0)
              clsMem.VFI_TransType = "01";
            if (Conversions.ToInteger(clsMem.VFI_TransType) < 1 | Conversions.ToInteger(clsMem.VFI_TransType) > 7)
            {
              clsMem.VFI_RespCode = "ZC";
              clsMem.VFI_RespMess = "Invalid Txn Type";
              this.Trace("VFI_GetAuth Err :" + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
            }
            else if (!this.ValidateAmount(ref clsMem.VFI_Amount))
            {
              clsMem.VFI_RespCode = "Z4";
              clsMem.VFI_RespMess = "Zero Amount not allowed";
              this.SetError(ref clsMem);
              this.Trace("VFI_GetAuth error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            }
            else if (!this.ValidateECRRcptNum(ref clsMem.VFI_ECRRcptNum))
            {
              clsMem.VFI_RespCode = "Z5";
              clsMem.VFI_RespMess = "ECR Receipt Number is must";
              this.SetError(ref clsMem);
              this.Trace("VFI_GetAuth error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            }
            else
            {
              this.Serial_Port = new SerialPort();
              if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
              {
                clsMem.VFI_RespCode = "Z6";
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
                  clsMem.VFI_RespMess = "Port Error";
                this.Trace("VFI_GetAuth Connect Error.", clsMem.VFI_PTID);
                clsMem.FunctionStatus = false;
              }
              else if (!this.VFI_InitTxn(ref this.Serial_Port, ref clsMem))
              {
                clsMem.FunctionStatus = false;
              }
              else
              {
                string strData = strMsgType + "," + clsMem.VFI_TransType + "," + clsMem.VFI_Amount + "," + clsMem.VFI_CashAmount + "," + clsMem.VFI_ECRRcptNum + "," + clsMem.VFI_AdditionalInfo + ",{0},{1}," + clsMem.VFI_ApprovalCode + "," + clsMem.VFI_RRN + ",";
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo1, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo2, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo3, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo4, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo5, "", false) != 0)
                  strData = strData + clsMem.VFI_AddInInfo1 + "," + clsMem.VFI_AddInInfo2 + "," + clsMem.VFI_AddInInfo3 + "," + clsMem.VFI_AddInInfo4 + "," + clsMem.VFI_AddInInfo5 + ",";
                clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, strData, ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
              }
              if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
              {
                this.Trace("VFI_GetAuth disconnect Error.", clsMem.VFI_PTID);
                clsMem.FunctionStatus = false;
              }
              this.Trace("VFI_GetAuth success.", clsMem.VFI_PTID);
              comCMXECR.strInstruction = "";
            }
          }
          else
          {
            clsMem.VFI_RespCode = "Z2";
            clsMem.VFI_RespMess = "Error on Load settings";
            this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_GetAuth Err:" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("C", ref clsMem, flgXml);
      }
      this.SetResData(clsMem);
      return clsMem;
    }

    private bool VFI_InitTxn(ref SerialPort Serial_Port, ref clsDataFields clsMem)
    {
      byte[] numArray = new byte[0];
      string strMsgType = "A";
      bool flag;
      try
      {
        this.Trace("InitTxn starts.", clsMem.VFI_PTID);
        string strData = strMsgType + ",{0},{1},";
        if (!this.SendReqPkt(ref Serial_Port, strData, ref clsMem, false))
        {
          this.Trace("InitTxn Exchange error.", clsMem.VFI_PTID);
          flag = false;
          goto label_8;
        }
        else if (!this.ResPktProcess(Serial_Port, strMsgType, (int) this.Settings.TxnTimeout, ref clsMem, false))
        {
          this.Trace("InitTxn process error.", clsMem.VFI_PTID);
        }
        else
        {
          this.Trace("InitTxn success.", clsMem.VFI_PTID);
          clsMem.VFI_RespCode = "99";
          clsMem.VFI_RespMess = "System Error";
          flag = true;
          goto label_8;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "99";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("InitTxn Err:" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_8:
      return flag;
    }

    private clsDataFields VFI_VoidTrans(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "D";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        this.Trace("VFI_VoidTrans starts.", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = "System Error";
        comCMXECR.strInstruction = "";
        if (!this.ValidateLicense(ref this.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
            clsMem.VFI_RespMess = "Error on Load lic";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          this.LicVerified = true;
          clsMem.VFI_RespMess = "System Error";
          if (this.LoadSettings(clsMem.VFI_TID))
          {
            this.flgSysConfig = true;
            if (!this.ValidateAmount(ref clsMem.VFI_Amount))
            {
              clsMem.VFI_RespCode = "Z4";
              clsMem.VFI_RespMess = "Zero Amount not allowed";
              this.SetError(ref clsMem);
              this.Trace("VFI_VoidTrans error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            }
            else if (!this.ValidateECRRcptNum(ref clsMem.VFI_ECRRcptNum))
            {
              clsMem.VFI_RespCode = "Z5";
              clsMem.VFI_RespMess = "ECR Receipt Number is must";
              this.SetError(ref clsMem);
              this.Trace("VFI_VoidTrans error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            }
            else if (!this.ValidateECRRcptNum(ref clsMem.VFI_VoidReceiptNum))
            {
              clsMem.VFI_RespCode = "Z5";
              clsMem.VFI_RespMess = "Void Receipt Number is must";
              this.SetError(ref clsMem);
              this.Trace("VFI_VoidTrans error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            }
            else
            {
              this.Serial_Port = new SerialPort();
              if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
              {
                clsMem.VFI_RespCode = "Z6";
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
                  clsMem.VFI_RespMess = "Port Error";
                this.Trace("VFI_VoidTrans Connect Error.", clsMem.VFI_PTID);
                clsMem.FunctionStatus = false;
              }
              else if (!this.VFI_InitTxn(ref this.Serial_Port, ref clsMem))
              {
                clsMem.FunctionStatus = false;
              }
              else
              {
                string strData = strMsgType + "," + clsMem.VFI_VoidReceiptNum + "," + clsMem.VFI_Amount + "," + clsMem.VFI_CashAmount + "," + clsMem.VFI_ECRRcptNum + "," + clsMem.VFI_AdditionalInfo + ",{0},{1},";
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo1, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo2, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo3, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo4, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_AddInInfo5, "", false) != 0)
                  strData = strData + clsMem.VFI_AddInInfo1 + "," + clsMem.VFI_AddInInfo2 + "," + clsMem.VFI_AddInInfo3 + "," + clsMem.VFI_AddInInfo4 + "," + clsMem.VFI_AddInInfo5 + ",";
                clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, strData, ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
              }
              if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
              {
                this.Trace("VFI_VoidTrans disconnect Error.", clsMem.VFI_PTID);
                clsMem.FunctionStatus = false;
              }
              this.Trace("VFI_VoidTrans success.", clsMem.VFI_PTID);
              comCMXECR.strInstruction = "";
            }
          }
          else
          {
            clsMem.VFI_RespCode = "Z2";
            clsMem.VFI_RespMess = "Error on Load settings";
            this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_VoidTrans Err:" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      this.SetResData(clsMem);
      return clsMem;
    }

    private bool SendReqPkt(
      ref SerialPort Serial_Port,
      string strData,
      ref clsDataFields clsMem,
      bool flgDelay = true)
    {
      bool flag = false;
      byte[] numArray = new byte[1024];
      int index1 = 0;
      try
      {
        if (flgDelay)
        {
          Thread.Sleep(checked ((int) this.Settings.DelayTimeout * 1000));
          if (this.Settings.flgDoEvent)
            Application.DoEvents();
        }
        this.VFI_MacSourceData = DateAndTime.Now.ToString("yyyyMMddHHmmss");
        this.VFI_MAC = this.CalculateMAC(this.VFI_MacSourceData);
        strData = string.Format(strData, (object) this.VFI_MacSourceData, (object) this.VFI_MAC.Substring(0, 8));
        if (this.flgEnc)
          strData = this.EncryPkt(strData);
        numArray[index1] = this.STX[0];
        int byteIndex = checked (index1 + 1);
        Encoding.ASCII.GetBytes(strData, 0, strData.Length, numArray, byteIndex);
        int index2 = checked (byteIndex + strData.Length);
        numArray[index2] = this.ETX[0];
        int blen = checked (index2 + 1);
        numArray[blen] = this.GetLrc(numArray, blen);
        int Llen = checked (blen + 1);
        if (!this.ExchangePkt(ref Serial_Port, numArray, checked ((short) Llen), ref clsMem))
          this.Trace("SendReqPkt Exchange pos error.", clsMem.VFI_PTID);
        else
          flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z8";
        clsMem.VFI_RespMess = "Send Error " + exception.Message;
        this.Trace("SendReqPkt error :" + exception.Message, clsMem.VFI_PTID);
        this.Trace("SendReqPkt error :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool ExchangePkt(
      ref SerialPort Serial_Port,
      byte[] TxPkt,
      short Llen,
      ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        short num = 0;
        byte Number = 0;
        this.Trace("Exchange Pkt Starts", clsMem.VFI_PTID);
        while (num < (short) 3)
        {
          if (Serial_Port.WriteBufferSize < (int) Llen)
            this.Trace("WriteBufferSize: " + Serial_Port.WriteBufferSize.ToString(), clsMem.VFI_PTID);
          Serial_Port.Write(TxPkt, 0, (int) Llen);
          while (!Information.IsNothing((object) Serial_Port) && Serial_Port.IsOpen && Serial_Port.BytesToWrite >= 1)
          {
            Thread.Sleep(this.Settings.SleepTime);
            if (this.Settings.flgDoEvent)
              Application.DoEvents();
          }
          if (this.Settings.flgDoEvent)
            Application.DoEvents();
          Thread.Sleep(this.Settings.SleepTime);
          if (this.Settings.flgDoEvent)
            Application.DoEvents();
          this.Trace("Exchange Pkt Tx: ", TxPkt, (int) Llen, clsMem.VFI_PTID);
          DateTime Date1 = DateAndTime.Now.AddSeconds((double) this.Settings.Timeout);
          while (DateAndTime.DateDiff(DateInterval.Second, Date1, DateAndTime.Now) < 0L)
          {
            Application.DoEvents();
            if (Serial_Port.BytesToRead > 0)
            {
              Number = checked ((byte) Serial_Port.ReadByte());
              this.Trace("Exchange Pkt Rx : " + Conversion.Hex(Number), clsMem.VFI_PTID);
              if ((int) Number == (int) this.ACK[0] || (int) Number == (int) this.NAK[0])
                break;
            }
            else
              Thread.Sleep(100);
          }
          if ((int) Number != (int) this.ACK[0])
            checked { ++num; }
          else
            break;
        }
        if (num >= (short) 3)
        {
          clsMem.VFI_RespCode = "Z8";
          clsMem.VFI_RespMess = "Timeout / No Response from Device";
          this.Trace("Exchange Pkt Err - " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          flag = false;
          goto label_24;
        }
        else
        {
          this.Trace("Exchange Pkt Ends", clsMem.VFI_PTID);
          flag = true;
          goto label_24;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z8";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Exchange Pkt Err - " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_24:
      return flag;
    }

    private void ClearData(ref clsDataFields clsMem)
    {
      try
      {
        clsMem.VFI_ECRRcptNum = "";
        clsMem.VFI_TransType = "";
        clsMem.VFI_Amount = "";
        clsMem.VFI_CashAmount = "";
        clsMem.VFI_VoidReceiptNum = "";
        clsMem.VFI_AdditionalInfo = "";
        clsMem.VFI_OptOut = "";
        clsMem.VFI_ApprovalCode = "";
        this.ClearResData(ref clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Clear data Err:" + ex.ToString());
        ProjectData.ClearProjectError();
      }
    }

    private void ClearResData(ref clsDataFields clsMem)
    {
      try
      {
        clsMem.VFI_CardNum = "";
        clsMem.VFI_Expiry = "";
        clsMem.VFI_CHName = "";
        clsMem.VFI_MessNum = "";
        clsMem.VFI_CardSchemeName = "";
        clsMem.VFI_TransSource = "";
        clsMem.VFI_AuthMode = "";
        clsMem.VFI_CHVerification = "";
        clsMem.VFI_RespCode = "";
        clsMem.VFI_RespMess = "";
        clsMem.VFI_DateTime = "";
        clsMem.VFI_EMV_Label = "";
        clsMem.VFI_EMV_AID = "";
        clsMem.VFI_EMV_TVR = "";
        clsMem.VFI_EMV_TSI = "";
        clsMem.VFI_EMV_AC = "";
        clsMem.VFI_DBCount = "";
        clsMem.VFI_DBAmount = "";
        clsMem.VFI_CRCount = "";
        clsMem.VFI_CRAmount = "";
        clsMem.VFI_TID = "";
        clsMem.VFI_MID = "";
        clsMem.VFI_Batch = "";
        clsMem.VFI_EMVCID = "";
        clsMem.VFI_ExchRate = "";
        clsMem.VFI_PYCAmount = "";
        clsMem.VFI_MarkUp = "";
        clsMem.VFI_PYCCurr = "";
        clsMem.VFI_PYCCurrName = "";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Clear Res data Err:" + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
    }

    private bool ResPktProcess(
      SerialPort Serial_Port,
      string strMsgType,
      int tTimeout,
      ref clsDataFields clsMem,
      bool flgXml)
    {
      string strMsg = "";
      bool flag = false;
      try
      {
        DateTime dtTimeout = DateAndTime.Now.AddSeconds((double) tTimeout);
        byte[] RxPkt = new byte[0];
        do
        {
          int Llen = (int) this.RxBlock(ref Serial_Port, ref RxPkt, ref dtTimeout, strMsgType, ref clsMem);
          if (this.Settings.flgWaitRes & Llen < 1)
          {
            clsMem.VFI_RespCode = "ZG";
            clsMem.VFI_RespMess = "User Canceled Error";
            break;
          }
          if (Llen < 1)
          {
            clsMem.VFI_RespCode = "Z8";
            if (clsMem.VFI_RespMess.Length <= 0)
            {
              clsMem.VFI_RespMess = "No Response / Timeout ";
              break;
            }
            break;
          }
          if (!this.ProcessBlock(RxPkt, Llen, ref strMsg, ref clsMem, flgXml))
          {
            clsMem.VFI_RespCode = "Z9";
            clsMem.VFI_RespMess = "Process Error";
            this.Trace("ProcessBlock Error.", clsMem.VFI_PTID);
            break;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strMsgType, strMsg, false) == 0)
          {
            flag = true;
            break;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString("G", strMsg, false) == 0)
            this.Set_CurrentInstruction = comCMXECR.strInstruction;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString("O02", strMsg, false) != 0)
            goto label_15;
        }
        while (this.SplitImdRpt(ref Serial_Port, this.strCustData, this.SeqType, ref clsMem));
        goto label_17;
label_15:
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("ResPktProcess error :" + exception.Message, clsMem.VFI_PTID);
        this.Trace("ResPktProcess error :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
label_17:
      return flag;
    }

    private short RxBlock(
      ref SerialPort Serial_port,
      ref byte[] RxPkt,
      ref DateTime dtTimeout,
      string strMsgType,
      ref clsDataFields clsMem)
    {
      string Left = "";
      short num1;
      try
      {
        short num2 = 1;
        this.Trace("Rx Block Starts", clsMem.VFI_PTID);
        while (num2 < (short) 3)
        {
          short index = 0;
          bool flag1 = false;
          bool flag2 = false;
          RxPkt = new byte[4511];
          while (DateAndTime.DateDiff(DateInterval.Second, dtTimeout, DateAndTime.Now) < 0L)
          {
            if (Serial_port.BytesToRead <= 0)
            {
              if (this.Settings.flgDoEvent)
                Application.DoEvents();
              Thread.Sleep(10);
              if (this.Settings.flgDoEvent)
                Application.DoEvents();
              Thread.Sleep(this.Settings.SleepTime);
              if (this.Settings.flgDoEvent)
                Application.DoEvents();
              Thread.Sleep(0);
            }
            else
            {
              if (!flag2)
                index = (short) 0;
              RxPkt[(int) index] = checked ((byte) Serial_port.ReadByte());
              if ((int) RxPkt[(int) index] == (int) this.STX[0] & !flag1)
                flag2 = true;
              if (!flag1)
              {
                if (flag2 & (int) RxPkt[(int) index] == (int) this.ETX[0])
                  flag1 = true;
                if (flag2)
                {
                  checked { ++index; }
                  if (this.Settings.flgDoEvent)
                    Application.DoEvents();
                  Thread.Sleep(0);
                  if (this.Settings.flgDoEvent)
                    Application.DoEvents();
                }
              }
              else
                break;
            }
          }
          this.Trace("RX : ", RxPkt, (int) index, clsMem.VFI_PTID);
          if (DateAndTime.DateDiff(DateInterval.Second, dtTimeout, DateAndTime.Now) >= 0L & index <= (short) 0)
          {
            clsMem.VFI_RespCode = "Z8";
            clsMem.VFI_RespMess = "Timeout / No Response from Device";
            this.Trace("Rx Block Err - " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            goto label_45;
          }
          else
          {
            byte lrc = this.GetLrc(RxPkt, (int) index);
            if (index > (short) 2)
              Left = this.GetMsgType(RxPkt, 1, strMsgType.Length);
            if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, strMsgType, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "G", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left.Substring(0, 1), "O02".Substring(0, 1), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strMsgType.Substring(0, 1), "O02".Substring(0, 1), false) == 0) & (int) lrc == (int) RxPkt[(int) index])
            {
              Serial_port.Write(this.ACK, 0, 1);
              Thread.Sleep(10);
              if (this.Settings.flgDoEvent)
                Application.DoEvents();
              this.Trace("Rx Block - ACK sent", clsMem.VFI_PTID);
              num1 = index;
              goto label_46;
            }
            else
            {
              try
              {
                if (Serial_port.BytesToRead > 0)
                  this.Trace("Junk : " + Serial_port.ReadExisting(), clsMem.VFI_PTID);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, strMsgType, false) != 0)
              {
                clsMem.VFI_RespCode = "ZA";
                clsMem.VFI_RespMess = "Invalid Response(" + Left + "-" + strMsgType + ") from Device";
                this.Trace("RxBlock Err - " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
                goto label_45;
              }
              else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strMsgType, "G", false) == 0)
              {
                this.Trace("LRC Cal :" + lrc.ToString() + "," + Conversions.ToString(RxPkt[(int) index]), clsMem.VFI_PTID);
                Serial_port.Write(this.NAK, 0, 1);
                Thread.Sleep(10);
                if (this.Settings.flgDoEvent)
                  Application.DoEvents();
                this.Trace("Rx Block - NAK sent", clsMem.VFI_PTID);
                dtTimeout = DateAndTime.Now.AddSeconds((double) this.Settings.TxnTimeout);
                checked { ++num2; }
              }
            }
          }
        }
        clsMem.VFI_RespCode = "Z8";
        clsMem.VFI_RespMess = "Timeout / No Response from Device";
        this.Trace("Rx Block Er - " + this.VFI_RespMess, clsMem.VFI_PTID);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Rx Block ex - " + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("Rx Block Ends", clsMem.VFI_PTID);
      }
label_45:
      num1 = (short) 0;
label_46:
      return num1;
    }

    private bool ProcessBlock(
      byte[] RxPkt,
      int Llen,
      ref string strMsg,
      ref clsDataFields clsMem,
      bool flgXml)
    {
      bool flag1 = false;
      int index1 = 0;
      char fieldFs = this.FieldFs;
      bool flag2;
      try
      {
        this.Trace("Process Block.", clsMem.VFI_PTID);
        string strInput = Encoding.ASCII.GetString(RxPkt, 1, checked (Llen - 2));
        if (this.flgEnc)
          strInput = this.DecryPkt(strInput);
        if (strInput.Length <= 0)
        {
          flag2 = false;
          goto label_45;
        }
        else
        {
          char ch = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strInput.Substring(0, 1), "O02".Substring(0, 1), false) != 0 ? this.FieldFs : this.MessageFs;
          string[] TFields = strInput.Split(ch);
          strMsg = TFields[index1];
          int Index1 = checked (index1 + 1);
          string str = strMsg;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
          {
            case 3222007936:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E", false) == 0)
              {
                int num = 1;
                if (this.ProcessSettle(TFields, num, ref clsMem))
                {
                  clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, num, strMsg, flgXml);
                  break;
                }
                goto label_44;
              }
              else
                break;
            case 3238785555:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "D", false) == 0)
              {
                int Index2 = 1;
                if (this.ProcessVoid(TFields, Index2, ref clsMem))
                {
                  clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index2, strMsg, flgXml);
                  break;
                }
                goto label_44;
              }
              else
                break;
            case 3255563174:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "G", false) == 0)
              {
                comCMXECR.strInstruction = TFields[Index1];
                flag1 = true;
                break;
              }
              break;
            case 3272340793:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "F", false) == 0)
              {
                flag1 = this.ProcessReportData(TFields, ref clsMem);
                clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index1, strMsg, flgXml);
                break;
              }
              break;
            case 3289118412:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "A", false) == 0)
              {
                int index2 = 1;
                clsMem.VFI_RespCode = TFields[index2];
                int index3 = checked (index2 + 1);
                clsMem.VFI_RespMess = TFields[index3];
                int index4 = checked (index3 + 1);
                clsMem.VFI_TID = TFields[index4];
                int index5 = checked (index4 + 1);
                if (this.VerifyMACInit(TFields[index5], TFields[checked (index5 + 1)]))
                  break;
                goto label_44;
              }
              else
                break;
            case 3322673650:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "C", false) == 0)
              {
                int Index3 = 1;
                if (this.ProcessGetAuthTxn(TFields, Index3, ref clsMem))
                {
                  clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index3, strMsg, flgXml);
                  break;
                }
                goto label_44;
              }
              else
                break;
            case 3339451269:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "B", false) == 0)
              {
                if (this.ProcessGetMaskedCardNo(TFields, Index1, ref clsMem))
                {
                  clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index1, strMsg, flgXml);
                  break;
                }
                goto label_44;
              }
              else
                break;
            case 3356228888:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "M", false) == 0)
              {
                flag1 = this.ProcessTerminalInfo(TFields, ref clsMem);
                clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index1, strMsg, flgXml);
                break;
              }
              break;
            case 3373006507:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "L", false) == 0)
              {
                flag1 = this.ProcessReprint(TFields, ref clsMem);
                clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index1, strMsg, flgXml);
                break;
              }
              break;
            case 3406561745:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "N", false) == 0)
              {
                flag1 = this.ProcessLogOn(TFields, ref clsMem);
                clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index1, strMsg, flgXml);
                break;
              }
              break;
            case 3440116983:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "H", false) == 0)
              {
                this.ProcessPIE(TFields, ref clsMem);
                clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index1, strMsg, flgXml);
                break;
              }
              break;
            case 3456894602:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "K", false) == 0)
              {
                int Index4 = 1;
                flag1 = this.ProcessGetAuthTxn(TFields, Index4, ref clsMem);
                clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index4, strMsg, flgXml);
                break;
              }
              break;
            case 3574337935:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P", false) == 0)
              {
                flag1 = this.ProcessTidMid(TFields, ref clsMem);
                break;
              }
              break;
            case 3641637416:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O02", false) == 0)
              {
                int index6 = 1;
                this.SeqType = TFields[index6];
                int index7 = checked (index6 + 1);
                this.strCustData = TFields[index7];
                int num = checked (index7 + 1);
                flag2 = true;
                goto label_45;
              }
              else
                break;
            case 3691970273:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O01", false) == 0)
              {
                clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, TFields, Index1, strMsg, flgXml);
                flag2 = true;
                goto label_45;
              }
              else
                break;
            case 3742114125:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Z", false) == 0)
              {
                clsMem.VFI_RespCode = TFields[1];
                clsMem.VFI_RespMess = TFields[2];
                break;
              }
              break;
          }
          flag1 = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Process Block Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
label_44:
      flag2 = flag1;
label_45:
      return flag2;
    }

    private bool ProcessGetMaskedCardNo(string[] TFields, int Index, ref clsDataFields clsMem)
    {
      bool maskedCardNo;
      try
      {
        clsMem.VFI_RespCode = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_RespMess = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_Card_First7 = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_Card_Last4 = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_TID = TFields[Index];
        checked { ++Index; }
        if (this.VerifyMAC(TFields[Index], TFields[checked (Index + 1)]))
        {
          if (this.flgEnc)
            this.Trace(string.Format("First7:{0},TID:{1},Last4:{2},ResCode:{3},Message:{4} ", (object) clsMem.VFI_Card_First7, (object) clsMem.VFI_TID, (object) clsMem.VFI_Last5Txn, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess), clsMem.VFI_PTID);
          maskedCardNo = true;
          goto label_7;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("ProcessGetMaskedCardNo Block Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessGetMaskedCardNo Block Completed.", clsMem.VFI_PTID);
      }
      maskedCardNo = false;
label_7:
      return maskedCardNo;
    }

    private bool ProcessGetAuthTxn(string[] TFields, int Index, ref clsDataFields clsMem)
    {
      bool authTxn;
      try
      {
        this.ProcessGetAuthData(TFields, Index, ref clsMem);
        this.WriteTxn(clsMem);
        authTxn = true;
        goto label_4;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("ProcessGetAuthTxn Block Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessGetAuthTxn Block Completed.", clsMem.VFI_PTID);
      }
      authTxn = false;
label_4:
      return authTxn;
    }

    private bool ProcessGetAuthData(string[] TFields, int Index, ref clsDataFields clsMem)
    {
      bool authData;
      try
      {
        clsMem.VFI_RespCode = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_RespMess = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_TransType = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_ECRRcptNum = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_Amount = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CardNum = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_Expiry = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CHName = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CashAmount = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_MessNum = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CardSchemeName = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_TransSource = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_AuthMode = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CHVerification = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_ApprovalCode = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_DateTime = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_Label = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_AID = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_TVR = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_TSI = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_AC = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_AdditionalInfo = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_TID = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_Batch = TFields[Index];
        checked { ++Index; }
        if (this.VerifyMAC(TFields[Index], TFields[checked (Index + 1)]))
        {
          checked { ++Index; }
          checked { ++Index; }
          string strTrace = "";
          if (TFields.Length > checked (Index + 7))
          {
            clsMem.VFI_EMVCID = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_ExchRate = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_PYCAmount = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_MarkUp = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_PYCCurr = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_PYCCurrName = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_OptOut = TFields[Index];
            checked { ++Index; }
            this.ProcessTxnAddInfo(TFields, Index, ref strTrace, ref clsMem);
          }
          else
          {
            clsMem.VFI_EMVCID = "";
            clsMem.VFI_ExchRate = "";
            clsMem.VFI_PYCAmount = "";
            clsMem.VFI_MarkUp = "";
            clsMem.VFI_PYCCurr = "";
            clsMem.VFI_PYCCurrName = "";
            clsMem.VFI_OptOut = "";
          }
          if (this.flgEnc)
            this.Trace(string.Format("MID:{0},TID:{1},Date:{2},Amount:{3},AuthCode:{4},CardNo:{5},ReceiptNo:{6},ResCode:{7},Message:{8},CardType:{9},Batch:{10},ECRRcptNo:{11},EMVCID{12},ExchRate{13},PYCAmount{14},MarkUp{15},PYCCurr{16},PYCCurrName{17},OptOut{18} {19}", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_DateTime, (object) clsMem.VFI_Amount, (object) clsMem.VFI_ApprovalCode, (object) clsMem.VFI_CardNum, (object) clsMem.VFI_MessNum, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_CardSchemeName, (object) clsMem.VFI_Batch, (object) clsMem.VFI_ECRRcptNum, (object) clsMem.VFI_EMVCID, (object) clsMem.VFI_ExchRate, (object) clsMem.VFI_PYCAmount, (object) clsMem.VFI_MarkUp, (object) clsMem.VFI_PYCCurr, (object) clsMem.VFI_PYCCurrName, (object) clsMem.VFI_OptOut, (object) strTrace), clsMem.VFI_PTID);
          authData = true;
          goto label_10;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("ProcessGetAuthTxn Block Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessGetAuthTxn Block Completed.", clsMem.VFI_PTID);
      }
      authData = false;
label_10:
      return authData;
    }

    private bool ProcessTxnAddInfo(
      string[] TFields,
      int Index1,
      ref string strTrace,
      ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        this.Trace("ProcessTxnAddInfo Block started.", clsMem.VFI_PTID);
        if (TFields.Length >= checked (Index1 + 1))
        {
          clsMem.VFI_RRN = TFields[Index1];
          checked { ++Index1; }
          strTrace = strTrace + ",RRN:" + clsMem.VFI_RRN;
          this.ProcessAddInfo(TFields, ref Index1, ref strTrace, ref clsMem);
        }
        flag = true;
        goto label_6;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("ProcessTxnAddInfo Block Err - " + ex.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessTxnAddInfo Block Completed.", clsMem.VFI_PTID);
      }
      flag = false;
label_6:
      return flag;
    }

    private bool ProcessAddInfo(
      string[] TFields,
      ref int Index1,
      ref string strTrace,
      ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        this.Trace("ProcessAddInfo Block started.", clsMem.VFI_PTID);
        if (TFields.Length >= checked (Index1 + 1))
        {
          clsMem.VFI_AddInfo1 = TFields[Index1];
          checked { ++Index1; }
          strTrace = strTrace + ",AddInfo1:" + clsMem.VFI_AddInfo1;
          if (TFields.Length >= checked (Index1 + 1))
          {
            clsMem.VFI_AddInfo2 = TFields[Index1];
            checked { ++Index1; }
            strTrace = strTrace + ",AddInfo2" + clsMem.VFI_AddInfo2;
            if (TFields.Length >= checked (Index1 + 1))
            {
              clsMem.VFI_AddInfo3 = TFields[Index1];
              checked { ++Index1; }
              strTrace = strTrace + ",AddInfo3" + clsMem.VFI_AddInfo3;
              if (TFields.Length >= checked (Index1 + 1))
              {
                clsMem.VFI_AddInfo4 = TFields[Index1];
                checked { ++Index1; }
                strTrace = strTrace + ",AddInfo4" + clsMem.VFI_AddInfo4;
                if (TFields.Length >= checked (Index1 + 1))
                {
                  clsMem.VFI_AddInfo5 = TFields[Index1];
                  checked { ++Index1; }
                  strTrace = strTrace + ",AddInfo5" + clsMem.VFI_AddInfo5;
                  if (TFields.Length >= checked (Index1 + 1))
                  {
                    clsMem.VFI_AddInfo6 = TFields[Index1];
                    checked { ++Index1; }
                    strTrace = strTrace + ",AddInfo6" + clsMem.VFI_AddInfo6;
                    if (TFields.Length >= checked (Index1 + 1))
                    {
                      clsMem.VFI_AddInfo7 = TFields[Index1];
                      checked { ++Index1; }
                      strTrace = strTrace + ",AddInfo7" + clsMem.VFI_AddInfo7;
                      if (TFields.Length >= checked (Index1 + 1))
                      {
                        clsMem.VFI_AddInfo8 = TFields[Index1];
                        checked { ++Index1; }
                        strTrace = strTrace + ",AddInfo8" + clsMem.VFI_AddInfo8;
                        if (TFields.Length >= checked (Index1 + 1))
                        {
                          clsMem.VFI_AddInfo9 = TFields[Index1];
                          checked { ++Index1; }
                          strTrace = strTrace + ",AddInfo9" + clsMem.VFI_AddInfo9;
                          if (TFields.Length >= checked (Index1 + 1))
                          {
                            clsMem.VFI_AddInfo10 = TFields[Index1];
                            checked { ++Index1; }
                            strTrace = strTrace + ",AddInfo10" + clsMem.VFI_AddInfo10;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        flag = true;
        goto label_15;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("ProcessAddInfo Block Err - " + ex.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessAddInfo Block Completed.", clsMem.VFI_PTID);
      }
      flag = false;
label_15:
      return flag;
    }

    private bool ProcessVoid(string[] TFields, int Index, ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        clsMem.VFI_RespCode = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_RespMess = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_ECRRcptNum = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_Amount = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CardNum = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_Expiry = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CHName = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CashAmount = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_MessNum = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CardSchemeName = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_TransSource = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_AuthMode = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_CHVerification = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_ApprovalCode = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_DateTime = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_Label = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_AID = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_TVR = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_TSI = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_EMV_AC = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_AdditionalInfo = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_TID = TFields[Index];
        checked { ++Index; }
        clsMem.VFI_Batch = TFields[Index];
        checked { ++Index; }
        if (this.VerifyMAC(TFields[Index], TFields[checked (Index + 1)]))
        {
          checked { ++Index; }
          checked { ++Index; }
          if (TFields.Length > checked (Index + 7))
          {
            clsMem.VFI_EMVCID = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_ExchRate = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_PYCAmount = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_MarkUp = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_PYCCurr = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_PYCCurrName = TFields[Index];
            checked { ++Index; }
            clsMem.VFI_OptOut = TFields[Index];
            checked { ++Index; }
          }
          else
          {
            clsMem.VFI_EMVCID = "";
            clsMem.VFI_ExchRate = "";
            clsMem.VFI_PYCAmount = "";
            clsMem.VFI_MarkUp = "";
            clsMem.VFI_PYCCurr = "";
            clsMem.VFI_PYCCurrName = "";
            clsMem.VFI_OptOut = "";
          }
          if (this.flgEnc)
            this.Trace(string.Format("MID:{0},TID:{1},Date:{2},Amount:{3},AuthCode:{4},CardNo:{5},ReceiptNo:{6},ResCode:{7},Message:{8},CardType:{9},Batch:{10},ECRRcptNo:{11}", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_DateTime, (object) clsMem.VFI_Amount, (object) clsMem.VFI_ApprovalCode, (object) clsMem.VFI_CardNum, (object) clsMem.VFI_MessNum, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_CardSchemeName, (object) clsMem.VFI_Batch, (object) clsMem.VFI_ECRRcptNum), clsMem.VFI_PTID);
          clsMem.VFI_TransType = "";
          this.WriteTxn(clsMem);
          flag = true;
          goto label_10;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("ProcessVoid Block Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessVoid Block Completed.", clsMem.VFI_PTID);
      }
      flag = false;
label_10:
      return flag;
    }

    private bool ProcessSettle(string[] TFields, int Index1, ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        clsMem.VFI_RespCode = TFields[Index1];
        checked { ++Index1; }
        clsMem.VFI_RespMess = TFields[Index1];
        checked { ++Index1; }
        clsMem.VFI_DBCount = TFields[Index1];
        checked { ++Index1; }
        clsMem.VFI_CRCount = TFields[Index1];
        checked { ++Index1; }
        clsMem.VFI_DBAmount = TFields[Index1];
        checked { ++Index1; }
        clsMem.VFI_CRAmount = TFields[Index1];
        checked { ++Index1; }
        clsMem.VFI_TID = TFields[Index1];
        checked { ++Index1; }
        clsMem.VFI_Batch = TFields[Index1];
        checked { ++Index1; }
        if (this.VerifyMAC(TFields[Index1], TFields[checked (Index1 + 1)]))
        {
          checked { ++Index1; }
          checked { ++Index1; }
          this.ProcessSettleDcc(TFields, ref Index1, ref clsMem);
          this.ProcessSettleCardRpt(TFields, Index1, ref clsMem);
          if (this.flgEnc)
            this.Trace(string.Format("RespCode{0},RespMess{1},DBCount{2},DBAmount{3},CRCount{4},CRAmount{5},TID{6},Batch{7},VFI_LHDBCount{8}, clsMem.VFI_LHCRCount{9}, clsMem.VFI_LHDBAmount{10}, clsMem.VFI_LHCRAmount{11}, clsMem.VFI_PYCDBCount{12}, clsMem.VFI_PYCCRCount{13}, clsMem.VFI_PYCDBAmount{14}, clsMem.VFI_PYCCRAmount{15} ", (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_DBCount, (object) clsMem.VFI_DBAmount, (object) clsMem.VFI_CRCount, (object) clsMem.VFI_CRAmount, (object) clsMem.VFI_TID, (object) clsMem.VFI_Batch, (object) clsMem.VFI_LHDBCount, (object) clsMem.VFI_LHCRCount, (object) clsMem.VFI_LHDBAmount, (object) clsMem.VFI_LHCRAmount, (object) clsMem.VFI_PYCDBCount, (object) clsMem.VFI_PYCCRCount, (object) clsMem.VFI_PYCDBAmount, (object) clsMem.VFI_PYCCRAmount), clsMem.VFI_PTID);
          flag = true;
          goto label_7;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("ProcessSettle Block Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessSettle Block Completed.", clsMem.VFI_PTID);
      }
      flag = false;
label_7:
      return flag;
    }

    private bool ProcessSettleCardRpt(string[] TFields, int Index1, ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        this.Trace("ProcessSettleCardRpt Block started.", clsMem.VFI_PTID);
        if (TFields.Length > checked (Index1 + 1))
        {
          clsMem.VFI_CardTypes = Conversions.ToInteger(TFields[Index1]);
          checked { ++Index1; }
          int num1 = checked (clsMem.VFI_CardTypes - 1);
          int num2 = 0;
          while (num2 <= num1)
          {
            if (TFields.Length > checked (Index1 + 5))
            {
              switch (num2)
              {
                case 0:
                  clsMem.VFI_CardType0_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType0_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType0_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType0_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType0_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 1:
                  clsMem.VFI_CardType1_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType1_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType1_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType1_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType1_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 2:
                  clsMem.VFI_CardType2_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType2_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType2_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType2_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType2_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 3:
                  clsMem.VFI_CardType3_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType3_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType3_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType3_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType3_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 4:
                  clsMem.VFI_CardType4_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType4_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType4_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType4_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType4_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 5:
                  clsMem.VFI_CardType5_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType5_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType5_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType5_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType5_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 6:
                  clsMem.VFI_CardType6_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType6_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType6_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType6_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType6_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 7:
                  clsMem.VFI_CardType7_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType7_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType7_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType7_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType7_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 8:
                  clsMem.VFI_CardType8_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType8_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType8_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType8_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType8_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                case 9:
                  clsMem.VFI_CardType9_CardName = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType9_DBCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType9_CRCount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType9_DBAmount = TFields[Index1];
                  checked { ++Index1; }
                  clsMem.VFI_CardType9_CRAmount = TFields[Index1];
                  checked { ++Index1; }
                  break;
                default:
                  goto label_16;
              }
              checked { ++num2; }
            }
            else
              goto label_35;
          }
label_16:
          if (TFields.Length > Index1)
          {
            clsMem.VFI_DccCardTypes = Conversions.ToInteger(TFields[Index1]);
            checked { ++Index1; }
            int num3 = checked (clsMem.VFI_DccCardTypes - 1);
            int num4 = 0;
            while (num4 <= num3)
            {
              if (TFields.Length > checked (Index1 + 5))
              {
                switch (num4)
                {
                  case 0:
                    clsMem.VFI_DccCardType0_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType0_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType0_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType0_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType0_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 1:
                    clsMem.VFI_DccCardType1_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType1_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType1_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType1_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType1_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 2:
                    clsMem.VFI_DccCardType2_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType2_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType2_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType2_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType2_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 3:
                    clsMem.VFI_DccCardType3_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType3_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType3_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType3_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType3_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 4:
                    clsMem.VFI_DccCardType4_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType4_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType4_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType4_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType4_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 5:
                    clsMem.VFI_DccCardType5_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType5_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType5_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType5_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType5_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 6:
                    clsMem.VFI_DccCardType6_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType6_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType6_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType6_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType6_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 7:
                    clsMem.VFI_DccCardType7_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType7_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType7_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType7_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType7_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 8:
                    clsMem.VFI_DccCardType8_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType8_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType8_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType8_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType8_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  case 9:
                    clsMem.VFI_DccCardType9_CardName = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType9_DBCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType9_CRCount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType9_DBAmount = TFields[Index1];
                    checked { ++Index1; }
                    clsMem.VFI_DccCardType9_CRAmount = TFields[Index1];
                    checked { ++Index1; }
                    break;
                  default:
                    goto label_32;
                }
                checked { ++num4; }
              }
              else
                goto label_35;
            }
label_32:
            flag = true;
            goto label_36;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("ProcessSettleCardRpt Block Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessSettleCardRpt Block Completed.", clsMem.VFI_PTID);
      }
label_35:
      flag = false;
label_36:
      return flag;
    }

    private bool ProcessSettleDcc(string[] TFields, ref int Index1, ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        this.Trace("ProcessSettleDcc Block started.", clsMem.VFI_PTID);
        if (TFields.Length > checked (Index1 + 8))
        {
          clsMem.VFI_LHDBCount = TFields[Index1];
          checked { ++Index1; }
          clsMem.VFI_LHCRCount = TFields[Index1];
          checked { ++Index1; }
          clsMem.VFI_LHDBAmount = TFields[Index1];
          checked { ++Index1; }
          clsMem.VFI_LHCRAmount = TFields[Index1];
          checked { ++Index1; }
          clsMem.VFI_PYCDBCount = TFields[Index1];
          checked { ++Index1; }
          clsMem.VFI_PYCCRCount = TFields[Index1];
          checked { ++Index1; }
          clsMem.VFI_PYCDBAmount = TFields[Index1];
          checked { ++Index1; }
          clsMem.VFI_PYCCRAmount = TFields[Index1];
          checked { ++Index1; }
        }
        else
        {
          clsMem.VFI_LHDBCount = "";
          clsMem.VFI_LHCRCount = "";
          clsMem.VFI_LHDBAmount = "";
          clsMem.VFI_LHCRAmount = "";
          clsMem.VFI_PYCDBCount = "";
          clsMem.VFI_PYCCRCount = "";
          clsMem.VFI_PYCDBAmount = "";
          clsMem.VFI_PYCCRAmount = "";
          checked { Index1 += 8; }
        }
        flag = true;
        goto label_7;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("ProcessSettleDcc Block Err - " + exception.Message, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace("ProcessSettleDcc Block Completed.", clsMem.VFI_PTID);
      }
      flag = false;
label_7:
      return flag;
    }

    private void SetResData(clsDataFields clsMem)
    {
      try
      {
        this.VFI_CardNum = clsMem.VFI_CardNum;
        this.VFI_Expiry = clsMem.VFI_Expiry;
        this.VFI_CHName = clsMem.VFI_CHName;
        this.VFI_MessNum = clsMem.VFI_MessNum;
        this.VFI_CardSchemeName = clsMem.VFI_CardSchemeName;
        this.VFI_TransSource = clsMem.VFI_TransSource;
        this.VFI_AuthMode = clsMem.VFI_AuthMode;
        this.VFI_CHVerification = clsMem.VFI_CHVerification;
        this.VFI_RespCode = clsMem.VFI_RespCode;
        this.VFI_RespMess = clsMem.VFI_RespMess;
        this.VFI_ApprovalCode = clsMem.VFI_ApprovalCode;
        this.VFI_DateTime = clsMem.VFI_DateTime;
        this.VFI_EMV_Label = clsMem.VFI_EMV_Label;
        this.VFI_EMV_AID = clsMem.VFI_EMV_AID;
        this.VFI_EMV_TVR = clsMem.VFI_EMV_TVR;
        this.VFI_EMV_TSI = clsMem.VFI_EMV_TSI;
        this.VFI_EMV_AC = clsMem.VFI_EMV_AC;
        this.VFI_DBCount = clsMem.VFI_DBCount;
        this.VFI_DBAmount = clsMem.VFI_DBAmount;
        this.VFI_CRCount = clsMem.VFI_CRCount;
        this.VFI_CRAmount = clsMem.VFI_CRAmount;
        this.VFI_MID = clsMem.VFI_MID;
        this.VFI_Batch = clsMem.VFI_Batch;
        this.VFI_TID = clsMem.VFI_TID;
        this.VFI_AdditionalInfo = clsMem.VFI_AdditionalInfo;
        this.VFI_Amount = clsMem.VFI_Amount;
        this.VFI_ECRRcptNum = clsMem.VFI_ECRRcptNum;
        this.VFI_TransType = clsMem.VFI_TransType;
        this.VFI_AdditionalInfo = clsMem.VFI_AdditionalInfo;
        this.VFI_ExchRate = clsMem.VFI_ExchRate;
        this.VFI_PYCAmount = clsMem.VFI_PYCAmount;
        this.VFI_MarkUp = clsMem.VFI_MarkUp;
        this.VFI_PYCCurr = clsMem.VFI_PYCCurr;
        this.VFI_PYCCurrName = clsMem.VFI_PYCCurrName;
        this.VFI_RRN = clsMem.VFI_RRN;
        this.VFI_VoidReceiptNum = clsMem.VFI_VoidReceiptNum;
        this.VFI_PYCDBCount = clsMem.VFI_PYCDBCount;
        this.VFI_PYCCRCount = clsMem.VFI_PYCCRCount;
        this.VFI_PYCDBAmount = clsMem.VFI_PYCDBAmount;
        this.VFI_PYCCRAmount = clsMem.VFI_PYCCRAmount;
        this.VFI_LHDBCount = clsMem.VFI_LHDBCount;
        this.VFI_LHCRCount = clsMem.VFI_LHCRCount;
        this.VFI_LHDBAmount = clsMem.VFI_LHDBAmount;
        this.VFI_LHCRAmount = clsMem.VFI_LHCRAmount;
        this.VFI_CashAmount = clsMem.VFI_CashAmount;
        this.VFI_OrgionalRcptNum = clsMem.VFI_OrgionalRcptNum;
        this.VFI_EMVCID = clsMem.VFI_EMVCID;
        this.VFI_OptOut = clsMem.VFI_OptOut;
        this.VFI_Card_First7 = clsMem.VFI_Card_First7;
        this.VFI_Card_Last4 = clsMem.VFI_Card_Last4;
        this.VFI_BalanceAmount = clsMem.VFI_BalanceAmount;
        this.VFI_Last5Txn = clsMem.VFI_Last5Txn;
        this.VFI_CardTypes = clsMem.VFI_CardTypes;
        this.VFI_DccCardTypes = clsMem.VFI_DccCardTypes;
        this.VFI_CardType0_CardName = clsMem.VFI_CardType0_CardName;
        this.VFI_CardType0_DBCount = clsMem.VFI_CardType0_DBCount;
        this.VFI_CardType0_CRCount = clsMem.VFI_CardType0_CRCount;
        this.VFI_CardType0_DBAmount = clsMem.VFI_CardType0_DBAmount;
        this.VFI_CardType0_CRAmount = clsMem.VFI_CardType0_CRAmount;
        this.VFI_CardType1_CardName = clsMem.VFI_CardType1_CardName;
        this.VFI_CardType1_DBCount = clsMem.VFI_CardType1_DBCount;
        this.VFI_CardType1_CRCount = clsMem.VFI_CardType1_CRCount;
        this.VFI_CardType1_DBAmount = clsMem.VFI_CardType1_DBAmount;
        this.VFI_CardType1_CRAmount = clsMem.VFI_CardType1_CRAmount;
        this.VFI_CardType2_CardName = clsMem.VFI_CardType2_CardName;
        this.VFI_CardType2_DBCount = clsMem.VFI_CardType2_DBCount;
        this.VFI_CardType2_CRCount = clsMem.VFI_CardType2_CRCount;
        this.VFI_CardType2_DBAmount = clsMem.VFI_CardType2_DBAmount;
        this.VFI_CardType2_CRAmount = clsMem.VFI_CardType2_CRAmount;
        this.VFI_CardType3_CardName = clsMem.VFI_CardType3_CardName;
        this.VFI_CardType3_DBCount = clsMem.VFI_CardType3_DBCount;
        this.VFI_CardType3_CRCount = clsMem.VFI_CardType3_CRCount;
        this.VFI_CardType3_DBAmount = clsMem.VFI_CardType3_DBAmount;
        this.VFI_CardType3_CRAmount = clsMem.VFI_CardType3_CRAmount;
        this.VFI_CardType4_CardName = clsMem.VFI_CardType4_CardName;
        this.VFI_CardType4_DBCount = clsMem.VFI_CardType4_DBCount;
        this.VFI_CardType4_CRCount = clsMem.VFI_CardType4_CRCount;
        this.VFI_CardType4_DBAmount = clsMem.VFI_CardType4_DBAmount;
        this.VFI_CardType4_CRAmount = clsMem.VFI_CardType4_CRAmount;
        this.VFI_CardType5_CardName = clsMem.VFI_CardType5_CardName;
        this.VFI_CardType5_DBCount = clsMem.VFI_CardType5_DBCount;
        this.VFI_CardType5_CRCount = clsMem.VFI_CardType5_CRCount;
        this.VFI_CardType5_DBAmount = clsMem.VFI_CardType5_DBAmount;
        this.VFI_CardType5_CRAmount = clsMem.VFI_CardType5_CRAmount;
        this.VFI_CardType6_CardName = clsMem.VFI_CardType6_CardName;
        this.VFI_CardType6_DBCount = clsMem.VFI_CardType6_DBCount;
        this.VFI_CardType6_CRCount = clsMem.VFI_CardType6_CRCount;
        this.VFI_CardType6_DBAmount = clsMem.VFI_CardType6_DBAmount;
        this.VFI_CardType6_CRAmount = clsMem.VFI_CardType6_CRAmount;
        this.VFI_CardType7_CardName = clsMem.VFI_CardType7_CardName;
        this.VFI_CardType7_DBCount = clsMem.VFI_CardType7_DBCount;
        this.VFI_CardType7_CRCount = clsMem.VFI_CardType7_CRCount;
        this.VFI_CardType7_DBAmount = clsMem.VFI_CardType7_DBAmount;
        this.VFI_CardType7_CRAmount = clsMem.VFI_CardType7_CRAmount;
        this.VFI_CardType8_CardName = clsMem.VFI_CardType8_CardName;
        this.VFI_CardType8_DBCount = clsMem.VFI_CardType8_DBCount;
        this.VFI_CardType8_CRCount = clsMem.VFI_CardType8_CRCount;
        this.VFI_CardType8_DBAmount = clsMem.VFI_CardType8_DBAmount;
        this.VFI_CardType8_CRAmount = clsMem.VFI_CardType8_CRAmount;
        this.VFI_CardType9_CardName = clsMem.VFI_CardType9_CardName;
        this.VFI_CardType9_DBCount = clsMem.VFI_CardType9_DBCount;
        this.VFI_CardType9_CRCount = clsMem.VFI_CardType9_CRCount;
        this.VFI_CardType9_DBAmount = clsMem.VFI_CardType9_DBAmount;
        this.VFI_CardType9_CRAmount = clsMem.VFI_CardType9_CRAmount;
        this.VFI_DccCardType0_CardName = clsMem.VFI_DccCardType0_CardName;
        this.VFI_DccCardType0_DBCount = clsMem.VFI_DccCardType0_DBCount;
        this.VFI_DccCardType0_CRCount = clsMem.VFI_DccCardType0_CRCount;
        this.VFI_DccCardType0_DBAmount = clsMem.VFI_DccCardType0_DBAmount;
        this.VFI_DccCardType0_CRAmount = clsMem.VFI_DccCardType0_CRAmount;
        this.VFI_DccCardType1_CardName = clsMem.VFI_DccCardType1_CardName;
        this.VFI_DccCardType1_DBCount = clsMem.VFI_DccCardType1_DBCount;
        this.VFI_DccCardType1_CRCount = clsMem.VFI_DccCardType1_CRCount;
        this.VFI_DccCardType1_DBAmount = clsMem.VFI_DccCardType1_DBAmount;
        this.VFI_DccCardType1_CRAmount = clsMem.VFI_DccCardType1_CRAmount;
        this.VFI_DccCardType2_CardName = clsMem.VFI_DccCardType2_CardName;
        this.VFI_DccCardType2_DBCount = clsMem.VFI_DccCardType2_DBCount;
        this.VFI_DccCardType2_CRCount = clsMem.VFI_DccCardType2_CRCount;
        this.VFI_DccCardType2_DBAmount = clsMem.VFI_DccCardType2_DBAmount;
        this.VFI_DccCardType2_CRAmount = clsMem.VFI_DccCardType2_CRAmount;
        this.VFI_DccCardType3_CardName = clsMem.VFI_DccCardType3_CardName;
        this.VFI_DccCardType3_DBCount = clsMem.VFI_DccCardType3_DBCount;
        this.VFI_DccCardType3_CRCount = clsMem.VFI_DccCardType3_CRCount;
        this.VFI_DccCardType3_DBAmount = clsMem.VFI_DccCardType3_DBAmount;
        this.VFI_DccCardType3_CRAmount = clsMem.VFI_DccCardType3_CRAmount;
        this.VFI_DccCardType4_CardName = clsMem.VFI_DccCardType4_CardName;
        this.VFI_DccCardType4_DBCount = clsMem.VFI_DccCardType4_DBCount;
        this.VFI_DccCardType4_CRCount = clsMem.VFI_DccCardType4_CRCount;
        this.VFI_DccCardType4_DBAmount = clsMem.VFI_DccCardType4_DBAmount;
        this.VFI_DccCardType4_CRAmount = clsMem.VFI_DccCardType4_CRAmount;
        this.VFI_DccCardType5_CardName = clsMem.VFI_DccCardType5_CardName;
        this.VFI_DccCardType5_DBCount = clsMem.VFI_DccCardType5_DBCount;
        this.VFI_DccCardType5_CRCount = clsMem.VFI_DccCardType5_CRCount;
        this.VFI_DccCardType5_DBAmount = clsMem.VFI_DccCardType5_DBAmount;
        this.VFI_DccCardType5_CRAmount = clsMem.VFI_DccCardType5_CRAmount;
        this.VFI_DccCardType6_CardName = clsMem.VFI_DccCardType6_CardName;
        this.VFI_DccCardType6_DBCount = clsMem.VFI_DccCardType6_DBCount;
        this.VFI_DccCardType6_CRCount = clsMem.VFI_DccCardType6_CRCount;
        this.VFI_DccCardType6_DBAmount = clsMem.VFI_DccCardType6_DBAmount;
        this.VFI_DccCardType6_CRAmount = clsMem.VFI_DccCardType6_CRAmount;
        this.VFI_DccCardType7_CardName = clsMem.VFI_DccCardType7_CardName;
        this.VFI_DccCardType7_DBCount = clsMem.VFI_DccCardType7_DBCount;
        this.VFI_DccCardType7_CRCount = clsMem.VFI_DccCardType7_CRCount;
        this.VFI_DccCardType7_DBAmount = clsMem.VFI_DccCardType7_DBAmount;
        this.VFI_DccCardType7_CRAmount = clsMem.VFI_DccCardType7_CRAmount;
        this.VFI_DccCardType8_CardName = clsMem.VFI_DccCardType8_CardName;
        this.VFI_DccCardType8_DBCount = clsMem.VFI_DccCardType8_DBCount;
        this.VFI_DccCardType8_CRCount = clsMem.VFI_DccCardType8_CRCount;
        this.VFI_DccCardType8_DBAmount = clsMem.VFI_DccCardType8_DBAmount;
        this.VFI_DccCardType8_CRAmount = clsMem.VFI_DccCardType8_CRAmount;
        this.VFI_DccCardType9_CardName = clsMem.VFI_DccCardType9_CardName;
        this.VFI_DccCardType9_DBCount = clsMem.VFI_DccCardType9_DBCount;
        this.VFI_DccCardType9_CRCount = clsMem.VFI_DccCardType9_CRCount;
        this.VFI_DccCardType9_DBAmount = clsMem.VFI_DccCardType9_DBAmount;
        this.VFI_DccCardType9_CRAmount = clsMem.VFI_DccCardType9_CRAmount;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("Clear Res data Err:" + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
    }

    private bool ValidateTid(ref string strTerminalId, int Llen = 8)
    {
      bool flag;
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strTerminalId, "", false) == 0)
          strTerminalId = "00";
        strTerminalId = strTerminalId.Trim();
        if (strTerminalId.Length <= 0)
          strTerminalId = "00";
        if (strTerminalId.Length > 0)
        {
          strTerminalId = strTerminalId.Length <= Llen ? strTerminalId.PadLeft(Llen, '0') : strTerminalId.Remove(Llen);
          flag = true;
          goto label_8;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("ValidateTid error : " + ex.Message);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_8:
      return flag;
    }

    private bool ValidateECRRcptNum(ref string strECRRcptNum)
    {
      bool flag;
      try
      {
        if (strECRRcptNum == null)
          strECRRcptNum = "";
        strECRRcptNum = strECRRcptNum.Trim();
        if (strECRRcptNum.Length > 0)
        {
          flag = true;
          goto label_6;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("ValidateECRRcptNum error : " + ex.Message);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_6:
      return flag;
    }

    private bool ValidateAmount(ref string strAmount)
    {
      bool flag;
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strAmount, "", false) == 0)
          strAmount = "00";
        strAmount = strAmount.Trim();
        if (strAmount.Length <= 0)
          strAmount = "00";
        if (Conversions.ToLong(strAmount.Replace(".", "")) > 0L)
        {
          flag = true;
          goto label_8;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("ValidateAmount error : " + ex.Message);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_8:
      return flag;
    }

    private clsDataFields VFI_Settle(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "E";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_Settle Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        comCMXECR.strInstruction = "";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_PTID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_17;
            }
          }
          this.Serial_Port = new SerialPort();
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_Settle Connect Error.", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else
            clsMem.FunctionStatus = this.VFI_InitTxn(ref this.Serial_Port, ref clsMem) && this.ReqResPkt(ref this.Serial_Port, strMsgType + ",{0},{1},", ref clsMem, strMsgType, (int) this.Settings.UploadTimeout, flgXml, this.Settings.Delay);
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
          {
            this.Trace("VFI_Settle Disconnect Err", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          this.Trace("VFI_Settle Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_Settle :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("E", ref clsMem, flgXml);
      }
label_17:
      this.SetResData(clsMem);
      return clsMem;
    }

    private clsDataFields VFI_Report(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "F";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_Report Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_PTID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_23;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_ReportType, "", false) == 0)
            clsMem.VFI_ReportType = "0";
          clsMem.VFI_ReportType = clsMem.VFI_ReportType.Trim();
          if (clsMem.VFI_ReportType.Length <= 0)
            clsMem.VFI_ReportType = "0";
          if (Conversions.ToInteger(clsMem.VFI_ReportType) < 0)
          {
            clsMem.VFI_RespCode = "ZI";
            clsMem.VFI_RespMess = "Zero Report not allowed";
            this.Trace("VFI_Report Err :" + clsMem.VFI_RespMess, clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else
          {
            this.Serial_Port = new SerialPort();
            if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
            {
              clsMem.VFI_RespCode = "Z6";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
                clsMem.VFI_RespMess = "Port Error";
              this.Trace("VFI_Report Connect Error.", clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
            }
            else
              clsMem.FunctionStatus = this.VFI_InitTxn(ref this.Serial_Port, ref clsMem) && this.ReqResPkt(ref this.Serial_Port, strMsgType + "," + clsMem.VFI_ReportType + ",{0},{1},", ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
            if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
            {
              this.Trace("VFI_Report Disconnect Err", clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
            }
            this.Trace("VFI_Report Success", clsMem.VFI_PTID);
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_Report :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("F", ref clsMem, flgXml);
      }
label_23:
      this.SetResData(clsMem);
      return clsMem;
    }

    private clsDataFields VFI_GetTerminalInfo(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "M";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_GetTerminalInfo Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_PTID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_17;
            }
          }
          this.Serial_Port = new SerialPort();
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_GetTerminalInfo Connect Error.", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else
            clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, strMsgType + ",{0},", ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
          {
            this.Trace("VFI_GetTerminalInfo Disconnect Err", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          this.Trace("VFI_GetTerminalInfo Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_GetTerminalInfo :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("M", ref clsMem, flgXml);
      }
label_17:
      this.SetResData(clsMem);
      return clsMem;
    }

    private clsDataFields VFI_Status(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "P";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_TermStatus Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_PTID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_20;
            }
          }
          this.Serial_Port = new SerialPort();
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_TermStatus Connect Error.", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else if (!this.ReqResPkt(ref this.Serial_Port, strMsgType + ",{0},{1},", ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay))
          {
            clsMem.FunctionStatus = false;
          }
          else
          {
            clsMem.FunctionStatus = true;
            clsMem.VFI_RespCode = "00";
            clsMem.VFI_RespMess = "Connection Success";
            if (flgXml)
              clsMem.VFI_XmlRespData = this.GenerateXml(clsMem, (string[]) null, 0, "CS");
          }
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
            this.Trace("VFI_TermStatus Disconnect error", clsMem.VFI_PTID);
          else
            this.Trace("VFI_TermStatus Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_TermStatus :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("CS", ref clsMem, flgXml);
      }
label_20:
      this.SetResData(clsMem);
      return clsMem;
    }

    private clsDataFields VFI_GetTidMid(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "P";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_GetTidMid Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_PTID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_17;
            }
          }
          this.Serial_Port = new SerialPort();
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_GetTidMid Connect Error.", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else
            clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, strMsgType + ",{0},{1},", ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
          {
            this.Trace("VFI_GetTidMid Disconnect Err", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          this.Trace("VFI_GetTidMid Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_GetTidMid :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("P", ref clsMem, flgXml);
      }
label_17:
      this.SetResData(clsMem);
      return clsMem;
    }

    private clsDataFields VFI_KeyLogOn(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "N";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_KeyLogOn Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_PTID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_17;
            }
          }
          this.Serial_Port = new SerialPort();
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_KeyLogOn Connect Error.", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else
            clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, strMsgType + ",{0},", ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
          {
            this.Trace("VFI_KeyLogOn Disconnect Err", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          this.Trace("VFI_KeyLogOn Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_KeyLogOn :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("N", ref clsMem, flgXml);
      }
label_17:
      this.SetResData(clsMem);
      return clsMem;
    }

    private clsDataFields VFI_TxnStatus(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "K";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_TxnStatus Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_PTID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_17;
            }
          }
          this.Serial_Port = new SerialPort();
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_TxnStatus Connect Error.", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else
            clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, strMsgType + "," + clsMem.VFI_ECRRcptNum + ",{0},{1},", ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
          {
            this.Trace("VFI_TxnStatus Disconnect Err", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          this.Trace("VFI_TxnStatus Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_TxnStatus :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("K", ref clsMem, flgXml);
      }
label_17:
      this.SetResData(clsMem);
      return clsMem;
    }

    private clsDataFields VFI_GetReprint(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "L";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_GetReprint Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_TID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_17;
            }
          }
          this.Serial_Port = new SerialPort();
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_GetReprint Connect Error.", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else
            clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, strMsgType + "," + clsMem.VFI_OrgionalRcptNum + ",{0},{1},", ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
          {
            this.Trace("VFI_GetReprint Disconnect Err", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          this.Trace("VFI_GetReprint Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_GetReprint :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("L", ref clsMem, flgXml);
      }
label_17:
      this.SetResData(clsMem);
      return clsMem;
    }

    private clsDataFields VFI_SelectedDCCOffer(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "O01";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        this.Trace("VFI_GetDCCOffer Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          clsMem.VFI_RespMess = "Error on Load lic.";
          this.SetError(ref clsMem);
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
        }
        else
        {
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_PTID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings.";
              this.SetError(ref clsMem);
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              goto label_17;
            }
          }
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_GetDCCOffer Connect Error. " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          }
          else
          {
            string[] strArray = new string[6]
            {
              strMsgType,
              this.MessageFs.ToString(),
              clsMem.VFI_AddInInfo1,
              this.MessageFs.ToString(),
              clsMem.VFI_OptOut,
              this.MessageFs.ToString()
            };
            clsMem.FunctionStatus = this.ReqResPkt(ref this.Serial_Port, string.Concat(strArray), ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
          }
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
            this.Trace("VFI_GetDCCOffer Disconnect error", clsMem.VFI_PTID);
          else
            this.Trace("VFI_GetDCCOffer Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.SetError(ref clsMem);
        this.Trace("VFI_GetDCCOffer error : " + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("C", ref clsMem);
      }
label_17:
      this.SetResData(clsMem);
      return clsMem;
    }

    internal clsDataFields VFI_GetMaskedCardNo(clsDataFields clsMem, bool flgXml)
    {
      string strMsgType = "B";
      try
      {
        clsMem.FunctionStatus = false;
        clsMem.VFI_PTID = clsMem.VFI_TID;
        clsMem.VFI_TID = "";
        this.Trace("VFI_GetMaskedCardNo Starts", clsMem.VFI_PTID);
        this.ClearResData(ref clsMem);
        clsMem.VFI_RespCode = "Z0";
        if (!this.ValidateLicense(ref clsMem.VFI_RespMess))
        {
          clsMem.VFI_RespCode = "Z1";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
            clsMem.VFI_RespMess = "Error on Load lic";
          this.Trace("Error on Load lic " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
          clsMem.FunctionStatus = false;
        }
        else
        {
          this.LicVerified = true;
          clsMem.VFI_RespMess = "System Error";
          if (!this.flgSysConfig)
          {
            if (this.LoadSettings(clsMem.VFI_TID))
            {
              this.flgSysConfig = true;
            }
            else
            {
              clsMem.VFI_RespCode = "Z2";
              clsMem.VFI_RespMess = "Error on Load settings";
              this.Trace("Error on Load Setting " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
              clsMem.FunctionStatus = false;
              goto label_19;
            }
          }
          this.Serial_Port = new SerialPort();
          if (!this.Open_Port(ref this.Serial_Port, this.Settings.PortName, this.Settings.BaudRate, this.Settings.DtrRts, clsMem.VFI_PTID, ref clsMem.VFI_RespMess))
          {
            clsMem.VFI_RespCode = "Z6";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(clsMem.VFI_RespMess, "", false) == 0)
              clsMem.VFI_RespMess = "Port Error";
            this.Trace("VFI_GetMaskedCardNo Connect Error.", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          else
            clsMem.FunctionStatus = this.VFI_InitTxn(ref this.Serial_Port, ref clsMem) && this.ReqResPkt(ref this.Serial_Port, strMsgType + ",{0},", ref clsMem, strMsgType, (int) this.Settings.TxnTimeout, flgXml, this.Settings.Delay);
          if (!this.Close_Port(ref this.Serial_Port, clsMem.VFI_PTID))
          {
            this.Trace("VFI_GetMaskedCardNo Disconnect Err", clsMem.VFI_PTID);
            clsMem.FunctionStatus = false;
          }
          this.Trace("VFI_GetMaskedCardNo Success", clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("VFI_GetMaskedCardNo :" + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("B", ref clsMem, flgXml);
      }
label_19:
      this.SetResData(clsMem);
      return clsMem;
    }

    public bool VFI_Status()
    {
      clsDataFields clsMem = new clsDataFields();
      bool functionStatus;
      try
      {
        clsMem.VFI_TID = this.VFI_TID;
        clsMem = this.VFI_Status(clsMem, false);
        this.SetResData(clsMem);
        functionStatus = clsMem.FunctionStatus;
        goto label_5;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z0";
        clsMem.VFI_RespMess = exception.Message;
        this.VFI_RespCode = clsMem.VFI_RespCode;
        this.VFI_RespMess = clsMem.VFI_RespMess;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.GenerateDefaultXml("CS");
      }
      functionStatus = clsMem.FunctionStatus;
label_5:
      return functionStatus;
    }

    private bool Trace(string strmsg, byte[] msg, int Llen, string Id)
    {
      bool flag;
      try
      {
        if (!this.Settings.Trace)
        {
          flag = true;
        }
        else
        {
          if (!Directory.Exists(this.Settings.TracePath))
            Directory.CreateDirectory(this.Settings.TracePath);
          try
          {
            byte[] numArray = new byte[checked (Llen + 1)];
            Array.Copy((Array) msg, 0, (Array) numArray, 0, Llen);
            Array.Reverse((Array) numArray);
            strmsg += this.ByteToBytestr(numArray);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          this.Trace(strmsg, Id);
          flag = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private bool Trace(string strMesage, string strID)
    {
      StreamWriter streamWriter = (StreamWriter) null;
      bool flag1;
      bool flag2;
      try
      {
        if (!this.Settings.Trace)
        {
          flag1 = true;
          goto label_12;
        }
        else
        {
          if (!Directory.Exists(this.Settings.TracePath))
            Directory.CreateDirectory(this.Settings.TracePath);
          streamWriter = new StreamWriter(this.Settings.TracePath + "\\" + DateAndTime.Now.ToString("yyyyMMdd") + strID + ".tlf", true);
          streamWriter.WriteLine(DateAndTime.Now.ToString("HH:mm:ss.fff") + " " + strMesage ?? "");
          streamWriter.Flush();
          streamWriter.Close();
          flag2 = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag2 = false;
        ProjectData.ClearProjectError();
      }
      try
      {
        if (streamWriter != null)
        {
          streamWriter.Close();
          streamWriter.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      flag1 = flag2;
label_12:
      return flag1;
    }

    public string VFI_GetAuth_Json(
      string TerminalID,
      string TransType,
      string Amount,
      string ECRRcptNum,
      string CashAmount,
      string AdditionalInfo)
    {
      string authJson;
      try
      {
        authJson = this.JSONReponse((object) this.VFI_GetAuth(new clsDataFields()
        {
          VFI_TID = TerminalID,
          VFI_PTID = TerminalID,
          VFI_ECRRcptNum = ECRRcptNum,
          VFI_TransType = TransType,
          VFI_Amount = Amount
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetAuth_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      authJson = "";
label_3:
      return authJson;
    }

    public string VFI_VoidTrans_Json(
      string TerminalID,
      string Amount,
      string VoidRcptNum,
      string ECRRcptNum)
    {
      string str;
      try
      {
        str = this.JSONReponse((object) this.VFI_VoidTrans(new clsDataFields()
        {
          VFI_TID = TerminalID,
          VFI_Amount = this.VFI_Amount,
          VFI_VoidReceiptNum = VoidRcptNum,
          VFI_ECRRcptNum = ECRRcptNum
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_VoidTrans_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      str = "";
label_3:
      return str;
    }

    public string VFI_Settle_Json(string TerminalID)
    {
      string str;
      try
      {
        str = this.JSONReponse((object) this.VFI_Settle(new clsDataFields()
        {
          VFI_TID = TerminalID
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Settle_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      str = "";
label_3:
      return str;
    }

    public string VFI_Report_Json(string TerminalID, string ReportType)
    {
      string str;
      try
      {
        str = this.JSONReponse((object) this.VFI_Report(new clsDataFields()
        {
          VFI_TID = TerminalID,
          VFI_ReportType = ReportType
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Report_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      str = "";
label_3:
      return str;
    }

    public string VFI_Status_Json(string TerminalID)
    {
      string str;
      try
      {
        str = this.JSONReponse((object) this.VFI_Status(new clsDataFields()
        {
          VFI_TID = TerminalID
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Status_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      str = "";
label_3:
      return str;
    }

    public string VFI_TxnStatus_Json(string TerminalId, string ECRRcptNum)
    {
      string str;
      try
      {
        str = this.JSONReponse((object) this.VFI_TxnStatus(new clsDataFields()
        {
          VFI_TID = TerminalId,
          VFI_ECRRcptNum = ECRRcptNum
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_TxnStatus_Json error : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      str = "";
label_3:
      return str;
    }

    public string VFI_KeyLogOn_Json(string TerminalID)
    {
      string str;
      try
      {
        str = this.JSONReponse((object) this.VFI_KeyLogOn(new clsDataFields()
        {
          VFI_TID = TerminalID
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_KeyLogOn_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      str = "";
label_3:
      return str;
    }

    public string VFI_GetTidMid_Json(string TerminalID)
    {
      string tidMidJson;
      try
      {
        tidMidJson = this.JSONReponse((object) this.VFI_GetTidMid(new clsDataFields()
        {
          VFI_TID = TerminalID
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetTidMid_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      tidMidJson = "";
label_3:
      return tidMidJson;
    }

    private string VFI_SelectDCCOffer_Json(string TerminalID, string RespCode, string DCC_OptIn)
    {
      string str;
      try
      {
        str = this.JSONReponse((object) this.VFI_SelectedDCCOffer(new clsDataFields()
        {
          VFI_TID = TerminalID,
          VFI_AddInInfo1 = RespCode,
          VFI_OptOut = DCC_OptIn
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_SelectDCCOffer_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      str = "";
label_3:
      return str;
    }

    public string VFI_GetTerminalInfo_Json(string TerminalID)
    {
      string terminalInfoJson;
      try
      {
        terminalInfoJson = this.JSONReponse((object) this.VFI_GetTerminalInfo(new clsDataFields()
        {
          VFI_TID = TerminalID
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetTerminalInfo_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      terminalInfoJson = "";
label_3:
      return terminalInfoJson;
    }

    public string VFI_GetReprint_Json(string TerminalID, string MessNum)
    {
      string reprintJson;
      try
      {
        reprintJson = this.JSONReponse((object) this.VFI_GetReprint(new clsDataFields()
        {
          VFI_TID = TerminalID,
          VFI_MessNum = MessNum
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetReprint_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      reprintJson = "";
label_3:
      return reprintJson;
    }

    public string VFI_GetMaskedCardNo_Json(string TerminalID)
    {
      string maskedCardNoJson;
      try
      {
        maskedCardNoJson = this.JSONReponse((object) this.VFI_GetMaskedCardNo(new clsDataFields()
        {
          VFI_TID = TerminalID
        }, false));
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetMaskedCardNo_Json error : " + ex.ToString(), TerminalID);
        ProjectData.ClearProjectError();
      }
      maskedCardNoJson = "";
label_3:
      return maskedCardNoJson;
    }

    private string JSONReponse(object obj)
    {
      string strMsg;
      try
      {
        DataContractJsonSerializer contractJsonSerializer = new DataContractJsonSerializer(obj.GetType());
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = memoryStream1;
        object objectValue = RuntimeHelpers.GetObjectValue(obj);
        contractJsonSerializer.WriteObject((Stream) memoryStream2, objectValue);
        strMsg = Encoding.Default.GetString(memoryStream1.ToArray());
        memoryStream1.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("JSONReponse error : " + ex.Message);
        strMsg = "";
        ProjectData.ClearProjectError();
      }
      this.Trace(strMsg);
      return strMsg;
    }

    private bool SplitImdRpt(
      ref SerialPort Serial_port,
      string strData,
      string strSeqType,
      ref clsDataFields clsMem)
    {
      bool flag = false;
      try
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = ^(local = ref clsMem.VFI_XmlRespData) + strData;
        local = str;
        string strData1 = "O02" + Conversions.ToString(this.MessageFs) + "00" + Conversions.ToString(this.MessageFs);
        if (!this.SendReqPkt(ref Serial_port, strData1, ref clsMem, false))
        {
          clsMem.VFI_RespCode = "Z7";
          clsMem.VFI_RespMess = "Send Error";
          this.Trace("VFI_ImdRpt Exchange pos error.", clsMem.VFI_PTID);
        }
        else
          flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("SplitImdRpt error : " + exception.Message, clsMem.VFI_PTID);
        this.Trace("SplitImdRpt error : " + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public string VFI_GetAuth_Xml(
      string TerminalID,
      string TransType,
      string Amount,
      string ECRRcptNum,
      string CashAmount,
      string AdditionalInfo)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_PTID = TerminalID;
        clsMem.VFI_ECRRcptNum = ECRRcptNum;
        clsMem.VFI_TransType = TransType;
        clsMem.VFI_Amount = Amount;
        clsMem = this.VFI_GetAuth(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetAuth_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("C", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_Refund_Xml(
      string TransType,
      string TerminalID,
      string Amount,
      string ECRRcptNum,
      string MerchantRefNo,
      string CardBin,
      string CardLast4)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_PTID = TerminalID;
        clsMem.VFI_ECRRcptNum = ECRRcptNum;
        clsMem.VFI_TransType = TransType;
        clsMem.VFI_Amount = Amount;
        clsMem.VFI_Card_First7 = CardBin;
        clsMem.VFI_Card_Last4 = CardLast4;
        clsMem = this.VFI_GetAuth(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Refund_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("C", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_VoidTrans_Xml(
      string TerminalID,
      string Amount,
      string VoidInvoiceNo,
      string ECRRcptNum)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_Amount = Amount;
        clsMem.VFI_MessNum = VoidInvoiceNo;
        clsMem.VFI_VoidReceiptNum = VoidInvoiceNo;
        clsMem.VFI_ECRRcptNum = ECRRcptNum;
        clsMem = this.VFI_VoidTrans(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("TCP_VoidTrans_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("D", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_Settle_Xml(string TerminalID)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalID;
        clsMem = this.VFI_Settle(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Settle_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("E", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_Report_Xml(string TerminalID, string ReportType)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_ReportType = ReportType;
        clsMem = this.VFI_Report(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Report_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("F", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_SummaryReport_Xml(string TerminalID, string ReportType)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        if (ReportType == null)
          ReportType = Conversions.ToString(1);
        else if (ReportType.Length < 1)
          ReportType = Conversions.ToString(1);
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_ReportType = ReportType;
        clsMem = this.VFI_Report(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Report_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("F", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_DetailReport_Xml(string TerminalID, string ReportType)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        if (ReportType == null)
          ReportType = Conversions.ToString(2);
        else if (ReportType.Length < 1)
          ReportType = Conversions.ToString(2);
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_ReportType = ReportType;
        clsMem = this.VFI_Report(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_DetailReport_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("F", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_TxnStatus_Xml(string TerminalID, string ECRRcptNum)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_ECRRcptNum = ECRRcptNum;
        clsMem = this.VFI_TxnStatus(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_TxnStatus_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("K", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_GetReprint_Xml(string TerminalId, string MessNum)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalId;
        clsMem.VFI_OrgionalRcptNum = MessNum;
        clsMem = this.VFI_GetReprint(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetReprint_Xml error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("L", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_SelectedDCCOffer_Xml(string TerminalId, string RespCode, string DCC_OptIn)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalId;
        clsMem.VFI_AddInInfo1 = RespCode;
        clsMem.VFI_OptOut = DCC_OptIn;
        clsMem = this.VFI_SelectedDCCOffer(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_SelectedDCCOffer_Xml error 1 : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      try
      {
        this.SetxmlResData("C", ref clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_SelectedDCCOffer_Xml error 2 : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_GetTerminalInfo_Xml(string TerminalId)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalId;
        clsMem = this.VFI_GetTerminalInfo(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetTerminalInfo_Xml error : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("C", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string getCurrentInstruction_Xml()
    {
      try
      {
        this.Trace("getCurrentInstruction : " + comCMXECR.strInstruction, this.VFI_TID);
        this.VFI_XmlRespData = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <CurrentMessage>" + comCMXECR.strInstruction + "</CurrentMessage> </Response>";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("getCurrentInstruction_Xml error : " + ex.ToString(), this.VFI_TID);
        ProjectData.ClearProjectError();
      }
      return this.VFI_XmlRespData;
    }

    public string VFI_Status_Xml(string TerminalId)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalId;
        clsMem = this.VFI_Status(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Status_Xml error : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("CS", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_KeyLogOn_Xml(string TerminalId)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalId;
        clsMem = this.VFI_KeyLogOn(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_KeyLogOn_Xml error : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("N", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_GetTidMid_Xml()
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = "";
        clsMem = this.VFI_GetTidMid(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetTidMid_Xml error : " + ex.ToString(), "");
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("P", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    public string VFI_GetMaskedCardNo_Xml(string TerminalId)
    {
      clsDataFields clsMem = new clsDataFields();
      bool flgXml = true;
      try
      {
        clsMem.VFI_TID = TerminalId;
        clsMem = this.VFI_GetMaskedCardNo(clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("CVFI_GetMaskedCardNo_Xml error : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("B", ref clsMem, flgXml);
      }
      return clsMem.VFI_XmlRespData;
    }

    private bool GetTerminalInfo(
      ref string MerchantName,
      ref string MerchantAddressLine1,
      ref string MerchantAddressLine2,
      ref string MerchantAddressLine3,
      ref string APPVersion,
      ref string MerchantId)
    {
      DataSet dataSet = new DataSet();
      bool terminalInfo;
      try
      {
        string str = this.GetCurrPath() + "\\TerminalInfo.xml";
        if (!File.Exists(str))
        {
          MerchantName = "";
          MerchantAddressLine1 = "";
          MerchantAddressLine2 = "";
          MerchantAddressLine3 = "";
          APPVersion = "";
          MerchantId = "";
        }
        else
        {
          int num = (int) dataSet.ReadXml(str);
          DataRow row = dataSet.Tables[0].Rows[0];
          MerchantName = Conversions.ToString(row[nameof (MerchantName)]);
          MerchantAddressLine1 = Conversions.ToString(row[nameof (MerchantAddressLine1)]);
          MerchantAddressLine2 = Conversions.ToString(row[nameof (MerchantAddressLine2)]);
          MerchantAddressLine3 = Conversions.ToString(row[nameof (MerchantAddressLine3)]);
          APPVersion = Conversions.ToString(row[nameof (APPVersion)]);
          MerchantId = Conversions.ToString(row["MID"]);
          terminalInfo = true;
          goto label_6;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("GetTerminalInfo error : " + exception.Message, this.VFI_TID);
        this.Trace("GetTerminalInfo error : " + exception.ToString(), this.VFI_TID);
        ProjectData.ClearProjectError();
      }
      terminalInfo = false;
label_6:
      return terminalInfo;
    }

    private void SaveTermInfo(
      string MerchantName,
      string MerchantAddressLine1,
      string MerchantAddressLine2,
      string MerchantAddressLine3,
      string APPVersion,
      string MerchantId)
    {
      DataSet dataSet = new DataSet();
      try
      {
        string str = this.GetCurrPath() + "\\TerminalInfo.xml";
        if (!File.Exists(str))
          this.CreateInfoFile(str);
        int num = (int) dataSet.ReadXml(str);
        try
        {
          foreach (DataRow row in dataSet.Tables[0].Rows)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MerchantName, "", false) != 0)
              row[nameof (MerchantName)] = (object) MerchantName;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MerchantAddressLine1, "", false) != 0)
              row[nameof (MerchantAddressLine1)] = (object) MerchantAddressLine1;
            row[nameof (MerchantAddressLine2)] = (object) MerchantAddressLine2;
            row[nameof (MerchantAddressLine3)] = (object) MerchantAddressLine3;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(APPVersion, "", false) != 0)
              row[nameof (APPVersion)] = (object) APPVersion;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MerchantId, "", false) != 0)
              row["MID"] = (object) APPVersion;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        dataSet.WriteXml(str);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("SaveInfo error : " + exception.Message, this.VFI_TID);
        this.Trace("SaveInfo error : " + exception.ToString(), this.VFI_TID);
        ProjectData.ClearProjectError();
      }
    }

    private void SaveInfo(string XmlData)
    {
      DataSet dataSet = new DataSet();
      try
      {
        if (XmlData == null || XmlData.Length < 1)
          return;
        this.SaveTermInfo(this.getNode(XmlData, "MerchantName"), this.getNode(XmlData, "MerchantAddressLine1"), this.getNode(XmlData, "MerchantAddressLine2"), this.getNode(XmlData, "MerchantAddressLine3"), this.getNode(XmlData, "AppVersion"), this.getNode(XmlData, "MID"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("SaveInfo error : " + exception.Message, this.VFI_TID);
        this.Trace("SaveInfo error : " + exception.ToString(), this.VFI_TID);
        ProjectData.ClearProjectError();
      }
    }

    private string getNode(string strData, string strTag)
    {
      string node = "";
      try
      {
        int num = strData.IndexOf("<" + strTag + ">");
        if (num >= 0)
        {
          int startIndex = checked (num + strTag.Length + 2);
          strData = strData.Substring(startIndex);
          int length = strData.IndexOf("<");
          if (length >= 0)
            node = strData.Substring(0, length);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return node;
    }

    private bool CreateInfoFile(string strPath)
    {
      StreamWriter streamWriter = (StreamWriter) null;
      bool infoFile = false;
      try
      {
        string str = "<?xml version=\"1.0\" standalone=\"yes\"?><NewDataSet> <TerminalInfo> <MerchantName></MerchantName> <MerchantAddressLine1></MerchantAddressLine1> <MerchantAddressLine2></MerchantAddressLine2> <MerchantAddressLine3></MerchantAddressLine3> <APPVersion></APPVersion> </TerminalInfo> </NewDataSet>";
        streamWriter = new StreamWriter(strPath, false);
        streamWriter.Write(str);
        streamWriter.Flush();
        streamWriter.Close();
        infoFile = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        streamWriter.Dispose();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return infoFile;
    }

    private string GenerateDefaultXml(string strMsg, bool flgXml = false)
    {
      string defaultXml = "";
      try
      {
        if (flgXml)
        {
          string str = strMsg;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
          {
            case 1708783731:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CS", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <POSConnection> <ResponseType></ResponseType> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> </POSConnection> </Response>";
                break;
              }
              break;
            case 3222007936:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Settle</ResponseType> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <BatchNo>" + this.VFI_Batch + "</BatchNo> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + defaultXml + " </Response>";
                break;
              }
              break;
            case 3238785555:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "D", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Void</ResponseType> <EDCTrxNo>" + this.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + this.VFI_TransType + "</TrxType> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + this.VFI_CardSchemeName + "</CardName> <ECRRcptNum>" + this.VFI_ECRRcptNum + "</ECRRcptNum> <MaskedCardNo>" + this.VFI_CardNum + "</MaskedCardNo> <CardExpiryDate>" + this.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + this.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + this.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + this.VFI_Amount + "</TrxAmount> <Currency>" + this.VFI_DomesticCurr + "</Currency> <TrxStatus>" + this.VFI_RespCode + "</TrxStatus> <AuthCode>" + this.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + this.VFI_TransSource + "</EntryMode> <BatchNo>" + this.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + this.VFI_EMV_Label + "</APPLabel> <RRN>" + this.VFI_RRN + "</RRN>  <EMVAID>" + this.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + this.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + this.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + this.VFI_EMV_AC + "</EMVAC> <ACInfo>" + this.VFI_EMVCID + "</ACInfo> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res() + " </Response>";
                break;
              }
              break;
            case 3272340793:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "F", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Report</ResponseType> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <BatchNo>" + this.VFI_Batch + "</BatchNo> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + defaultXml + " </Response>";
                break;
              }
              break;
            case 3322673650:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "C", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>GetAuth</ResponseType> <EDCTrxNo>" + this.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + this.VFI_TransType + "</TrxType> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + this.VFI_CardSchemeName + "</CardName> <ECRRcptNum>" + this.VFI_ECRRcptNum + "</ECRRcptNum> <MaskedCardNo>" + this.VFI_CardNum + "</MaskedCardNo> <CardExpiryDate>" + this.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + this.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + this.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + this.VFI_Amount + "</TrxAmount> <Currency>" + this.VFI_DomesticCurr + "</Currency> <TrxStatus>" + this.VFI_RespCode + "</TrxStatus> <AuthCode>" + this.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + this.VFI_TransSource + "</EntryMode> <BatchNo>" + this.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + this.VFI_EMV_Label + "</APPLabel> <RRN>" + this.VFI_RRN + "</RRN>  <EMVAID>" + this.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + this.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + this.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + this.VFI_EMV_AC + "</EMVAC> <ACInfo>" + this.VFI_EMVCID + "</ACInfo> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res() + " </Response>";
                break;
              }
              break;
            case 3356228888:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "M", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <TerminalInfo> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <PTID>" + this.VFI_PTID + "</PTID> <SerialNo>" + this.VFI_TslNo + "</SerialNo> <PartNo>" + this.VFI_AddInfo1 + "</PartNo> <ApplDateTime>" + this.VFI_AddInfo2 + "</ApplDateTime> <DownloadTime>" + this.VFI_AddInfo3 + "</DownloadTime> <OS>" + this.VFI_AddInfo4 + "</OS> <EOS>" + this.VFI_AddInfo5 + "</EOS> <CTLS>" + this.VFI_AddInfo6 + "</CTLS> <Application>" + this.VFI_POSApplicationVersion + "</Application> <Model>" + this.VFI_AddInfo7 + "</Model> <BatchNo>" + this.VFI_Batch + "</BatchNo> <HostIp>" + this.VFI_AddInfo8 + "</HostIp> <PortNo>" + this.VFI_AddInfo9 + "</PortNo> <SimIp>" + this.VFI_AddInfo10 + "</SimIp> <POSTime>" + this.VFI_DateTime + "</POSTime> <Nol>" + this.VFI_AddInfo11 + "</Nol> <RAM>" + this.VFI_AddInfo12 + "</RAM> <Flash>" + this.VFI_AddInfo13 + "</Flash> <Sdk>" + this.VFI_AddInfo14 + "</Sdk> </TerminalInfo>";
                break;
              }
              break;
            case 3373006507:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "L", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Reprint</ResponseType> <EDCTrxNo>" + this.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + this.VFI_TransType + "</TrxType> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + this.VFI_CardSchemeName + "</CardName> <ECRRcptNum>" + this.VFI_ECRRcptNum + "</ECRRcptNum> <MaskedCardNo>" + this.VFI_CardNum + "</MaskedCardNo> <CardExpiryDate>" + this.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + this.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + this.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + this.VFI_Amount + "</TrxAmount> <Currency>" + this.VFI_DomesticCurr + "</Currency> <TrxStatus>" + this.VFI_RespCode + "</TrxStatus> <AuthCode>" + this.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + this.VFI_TransSource + "</EntryMode> <BatchNo>" + this.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + this.VFI_EMV_Label + "</APPLabel> <RRN>" + this.VFI_RRN + "</RRN>  <EMVAID>" + this.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + this.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + this.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + this.VFI_EMV_AC + "</EMVAC> <ACInfo>" + this.VFI_EMVCID + "</ACInfo> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res() + " </Response>";
                break;
              }
              break;
            case 3406561745:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "N", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>KeyLogOn</ResponseType> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> </Response>";
                break;
              }
              break;
            case 3456894602:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "K", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>TxnStatus</ResponseType> <EDCTrxNo>" + this.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + this.VFI_TransType + "</TrxType> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + this.VFI_CardSchemeName + "</CardName> <ECRRcptNum>" + this.VFI_ECRRcptNum + "</ECRRcptNum> <MaskedCardNo>" + this.VFI_CardNum + "</MaskedCardNo> <CardExpiryDate>" + this.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + this.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + this.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + this.VFI_Amount + "</TrxAmount> <Currency>" + this.VFI_DomesticCurr + "</Currency> <TrxStatus>" + this.VFI_RespCode + "</TrxStatus> <AuthCode>" + this.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + this.VFI_TransSource + "</EntryMode> <BatchNo>" + this.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + this.VFI_EMV_Label + "</APPLabel> <RRN>" + this.VFI_RRN + "</RRN>  <EMVAID>" + this.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + this.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + this.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + this.VFI_EMV_AC + "</EMVAC> <ACInfo>" + this.VFI_EMVCID + "</ACInfo> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res() + " </Response>";
                break;
              }
              break;
            case 3641637416:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O02", false) == 0)
                break;
              break;
            case 3691970273:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O01", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <IsDCC></IsDCC> <MaxTimeout></MaxTimeout> <DCCResponse> <DCC_Details> <DCC_Local_Curr></DCC_Local_Curr> <DCC_Local_CurrCode></DCC_Local_CurrCode> <DCC_ForCurrency></DCC_ForCurrency> <DCC_ForCurrencyCode></DCC_ForCurrencyCode>  <DCC_Exchange_Rate></DCC_Exchange_Rate> <DCC_MarkUp></DCC_MarkUp> <DCC_Local_Amt></DCC_Local_Amt> <DCC_Amount></DCC_Amount> </DCC_Details> </DCCResponse>";
                break;
              }
              break;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("GenerateDefaultXml error : " + exception.Message, this.VFI_TID);
        this.Trace("GenerateDefaultXml error : " + exception.ToString(), this.VFI_TID);
        ProjectData.ClearProjectError();
      }
      return defaultXml;
    }

    private string GenerateDefaultXml(string strMsg, clsDataFields clsMem, bool flgXml = false)
    {
      string defaultXml = "";
      try
      {
        if (flgXml)
        {
          clsMem.VFI_FailureCode = clsMem.VFI_RespCode;
          clsMem.VFI_FailureMessage = clsMem.VFI_RespMess;
          string str = strMsg;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
          {
            case 1708783731:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CS", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <POSConnection> <ResponseType></ResponseType> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> </POSConnection> </Response>";
                break;
              }
              break;
            case 3222007936:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Settle</ResponseType> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + defaultXml + " </Response>";
                break;
              }
              break;
            case 3238785555:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "D", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Void</ResponseType> <EDCTrxNo>" + clsMem.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + clsMem.VFI_TransType + "</TrxType> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + clsMem.VFI_CardSchemeName + "</CardName> <ECRRcptNum>" + clsMem.VFI_ECRRcptNum + "</ECRRcptNum> <MaskedCardNo>" + clsMem.VFI_CardNum + "</MaskedCardNo> <CardExpiryDate>" + clsMem.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + clsMem.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + clsMem.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + clsMem.VFI_Amount + "</TrxAmount> <Currency>" + clsMem.VFI_DomesticCurr + "</Currency> <TrxStatus>" + clsMem.VFI_RespCode + "</TrxStatus> <AuthCode>" + clsMem.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + clsMem.VFI_TransSource + "</EntryMode> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + clsMem.VFI_EMV_Label + "</APPLabel> <RRN>" + clsMem.VFI_RRN + "</RRN> <EMVAID>" + clsMem.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + clsMem.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + clsMem.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + clsMem.VFI_EMV_AC + "</EMVAC> <ACInfo>" + clsMem.VFI_EMVCID + "</ACInfo> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res(clsMem) + "  </Response>";
                break;
              }
              break;
            case 3272340793:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "F", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Report</ResponseType> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + defaultXml + " </Response>";
                break;
              }
              break;
            case 3322673650:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "C", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>GetAuth</ResponseType> <EDCTrxNo>" + clsMem.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + clsMem.VFI_TransType + "</TrxType> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + clsMem.VFI_CardSchemeName + "</CardName> <ECRRcptNum>" + clsMem.VFI_ECRRcptNum + "</ECRRcptNum> <MaskedCardNo>" + clsMem.VFI_CardNum + "</MaskedCardNo> <CardExpiryDate>" + clsMem.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + clsMem.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + clsMem.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + clsMem.VFI_Amount + "</TrxAmount> <Currency>" + clsMem.VFI_DomesticCurr + "</Currency> <TrxStatus>" + clsMem.VFI_RespCode + "</TrxStatus> <AuthCode>" + clsMem.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + clsMem.VFI_TransSource + "</EntryMode> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + clsMem.VFI_EMV_Label + "</APPLabel> <RRN>" + clsMem.VFI_RRN + "</RRN> <EMVAID>" + clsMem.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + clsMem.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + clsMem.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + clsMem.VFI_EMV_AC + "</EMVAC> <ACInfo>" + clsMem.VFI_EMVCID + "</ACInfo> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res(clsMem) + " </Response>";
                break;
              }
              break;
            case 3356228888:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "M", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <TerminalInfo> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <PTID>" + clsMem.VFI_PTID + "</PTID> <SerialNo>" + clsMem.VFI_TslNo + "</SerialNo> <PartNo>" + clsMem.VFI_AddInfo1 + "</PartNo> <ApplDateTime>" + clsMem.VFI_AddInfo2 + "</ApplDateTime> <DownloadTime>" + clsMem.VFI_AddInfo3 + "</DownloadTime> <OS>" + clsMem.VFI_AddInfo4 + "</OS> <EOS>" + clsMem.VFI_AddInfo5 + "</EOS> <CTLS>" + clsMem.VFI_AddInfo6 + "</CTLS> <Application>" + clsMem.VFI_POSApplicationVersion + "</Application> <Model>" + clsMem.VFI_AddInfo7 + "</Model> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <HostIp>" + clsMem.VFI_AddInfo8 + "</HostIp> <PortNo>" + clsMem.VFI_AddInfo9 + "</PortNo> <SimIp>" + clsMem.VFI_AddInfo10 + "</SimIp> <POSTime>" + clsMem.VFI_DateTime + "</POSTime> <Nol>" + clsMem.VFI_AddInfo11 + "</Nol> <RAM>" + clsMem.VFI_AddInfo12 + "</RAM> <Flash>" + clsMem.VFI_AddInfo13 + "</Flash> <Sdk>" + clsMem.VFI_AddInfo14 + "</Sdk> </TerminalInfo> </Response>";
                break;
              }
              break;
            case 3373006507:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "L", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Reprint</ResponseType> <EDCTrxNo>" + clsMem.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + clsMem.VFI_TransType + "</TrxType> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + clsMem.VFI_CardSchemeName + "</CardName> <ECRRcptNum>" + clsMem.VFI_ECRRcptNum + "</ECRRcptNum> <MaskedCardNo>" + clsMem.VFI_CardNum + "</MaskedCardNo> <CardExpiryDate>" + clsMem.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + clsMem.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + clsMem.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + clsMem.VFI_Amount + "</TrxAmount> <Currency>" + clsMem.VFI_DomesticCurr + "</Currency> <TrxStatus>" + clsMem.VFI_RespCode + "</TrxStatus> <AuthCode>" + clsMem.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + clsMem.VFI_TransSource + "</EntryMode> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + clsMem.VFI_EMV_Label + "</APPLabel> <RRN>" + clsMem.VFI_RRN + "</RRN> <EMVAID>" + clsMem.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + clsMem.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + clsMem.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + clsMem.VFI_EMV_AC + "</EMVAC> <ACInfo>" + clsMem.VFI_EMVCID + "</ACInfo> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res(clsMem) + " </Response>";
                break;
              }
              break;
            case 3406561745:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "N", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>KeyLogOn</ResponseType> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> </Response>";
                break;
              }
              break;
            case 3456894602:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "K", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>TxnStatus</ResponseType> <EDCTrxNo>" + clsMem.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + clsMem.VFI_TransType + "</TrxType> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + clsMem.VFI_CardSchemeName + "</CardName> <ECRRcptNum>" + clsMem.VFI_ECRRcptNum + "</ECRRcptNum> <MaskedCardNo>" + clsMem.VFI_CardNum + "</MaskedCardNo> <CardExpiryDate>" + clsMem.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + clsMem.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + clsMem.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + clsMem.VFI_Amount + "</TrxAmount> <Currency>" + clsMem.VFI_DomesticCurr + "</Currency> <TrxStatus>" + clsMem.VFI_RespCode + "</TrxStatus> <AuthCode>" + clsMem.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + clsMem.VFI_TransSource + "</EntryMode> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + clsMem.VFI_EMV_Label + "</APPLabel> <RRN>" + clsMem.VFI_RRN + "</RRN> <EMVAID>" + clsMem.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + clsMem.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + clsMem.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + clsMem.VFI_EMV_AC + "</EMVAC> <ACInfo>" + clsMem.VFI_EMVCID + "</ACInfo> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res(clsMem) + " </Response>";
                break;
              }
              break;
            case 3641637416:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O02", false) == 0)
                break;
              break;
            case 3691970273:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O01", false) == 0)
              {
                defaultXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <IsDCC></IsDCC> <MaxTimeout></MaxTimeout> <DCCResponse> <DCC_Details> <DCC_Local_Curr></DCC_Local_Curr> <DCC_Local_CurrCode></DCC_Local_CurrCode> <DCC_ForCurrency></DCC_ForCurrency> <DCC_ForCurrencyCode></DCC_ForCurrencyCode>  <DCC_Exchange_Rate></DCC_Exchange_Rate> <DCC_MarkUp></DCC_MarkUp> <DCC_Local_Amt></DCC_Local_Amt> <DCC_Amount></DCC_Amount> </DCC_Details> </DCCResponse> </Response>";
                break;
              }
              break;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("GenerateDefaultXml error : " + exception.Message, clsMem.VFI_PTID);
        this.Trace("GenerateDefaultXml error : " + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return defaultXml;
    }

    private string GenerateXml(string[] TFields, int Index, string strMsg, bool flgXml = false)
    {
      string strMesage = "";
      try
      {
        if (flgXml)
        {
          try
          {
            this.chkIsEPP();
            this.GetTerminalInfo(ref this.VFI_MerchantName, ref this.VFI_Address1, ref this.VFI_Address2, ref this.VFI_Address3, ref this.VFI_POSApplicationVersion, ref this.VFI_MID);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          string str = strMsg;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
          {
            case 1708783731:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CS", false) == 0)
              {
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <POSConnection> <ResponseType></ResponseType> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> </POSConnection> </Response>";
                break;
              }
              break;
            case 3222007936:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E", false) == 0)
              {
                this.SaveInfo(this.VFI_XmlRespData);
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.VFI_XmlRespData + " </Response>";
                break;
              }
              break;
            case 3238785555:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "D", false) == 0)
              {
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Void</ResponseType> <EDCTrxNo>" + this.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + this.VFI_TransType + "</TrxType> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + this.VFI_CardSchemeName + "</CardName> <MaskedCardNo>" + this.VFI_CardNum + "</MaskedCardNo> <ECRRcptNum>" + this.VFI_ECRRcptNum + "</ECRRcptNum> <CardExpiryDate>" + this.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + this.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + this.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + this.VFI_Amount + "</TrxAmount> <Currency>" + this.VFI_DomesticCurr + "</Currency> <TrxStatus>" + this.VFI_RespCode + "</TrxStatus> <AuthCode>" + this.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + this.VFI_TransSource + "</EntryMode> <BatchNo>" + this.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + this.VFI_EMV_Label + "</APPLabel> <RRN>" + this.VFI_RRN + "</RRN>  <EMVAID>" + this.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + this.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + this.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + this.VFI_EMV_AC + "</EMVAC> <ACInfo>" + this.VFI_EMVCID + "</ACInfo> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res() + " </Response>";
                break;
              }
              break;
            case 3272340793:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "F", false) == 0)
              {
                this.SaveInfo(this.VFI_XmlRespData);
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.VFI_XmlRespData + " </Response>";
                break;
              }
              break;
            case 3322673650:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "C", false) == 0)
              {
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>GetAuth</ResponseType> <EDCTrxNo>" + this.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + this.VFI_TransType + "</TrxType> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + this.VFI_CardSchemeName + "</CardName> <MaskedCardNo>" + this.VFI_CardNum + "</MaskedCardNo> <ECRRcptNum>" + this.VFI_ECRRcptNum + "</ECRRcptNum> <CardExpiryDate>" + this.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + this.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + this.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + this.VFI_Amount + "</TrxAmount> <Currency>" + this.VFI_DomesticCurr + "</Currency> <TrxStatus>" + this.VFI_RespCode + "</TrxStatus> <AuthCode>" + this.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + this.VFI_TransSource + "</EntryMode> <BatchNo>" + this.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + this.VFI_EMV_Label + "</APPLabel> <RRN>" + this.VFI_RRN + "</RRN>  <EMVAID>" + this.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + this.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + this.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + this.VFI_EMV_AC + "</EMVAC> <ACInfo>" + this.VFI_EMVCID + "</ACInfo> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res() + " </Response>";
                break;
              }
              break;
            case 3356228888:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "M", false) == 0)
              {
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <TerminalInfo> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <PTID>" + this.VFI_PTID + "</PTID> <SerialNo>" + this.VFI_TslNo + "</SerialNo> <PartNo>" + this.VFI_AddInfo1 + "</PartNo> <ApplDateTime>" + this.VFI_AddInfo2 + "</ApplDateTime> <DownloadTime>" + this.VFI_AddInfo3 + "</DownloadTime> <OS>" + this.VFI_AddInfo4 + "</OS> <EOS>" + this.VFI_AddInfo5 + "</EOS> <CTLS>" + this.VFI_AddInfo6 + "</CTLS> <Application>" + this.VFI_POSApplicationVersion + "</Application> <Model>" + this.VFI_AddInfo7 + "</Model> <BatchNo>" + this.VFI_Batch + "</BatchNo> <HostIp>" + this.VFI_AddInfo8 + "</HostIp> <PortNo>" + this.VFI_AddInfo9 + "</PortNo> <SimIp>" + this.VFI_AddInfo10 + "</SimIp> <POSTime>" + this.VFI_DateTime + "</POSTime> <Nol>" + this.VFI_AddInfo11 + "</Nol> <RAM>" + this.VFI_AddInfo12 + "</RAM> <Flash>" + this.VFI_AddInfo13 + "</Flash> <Sdk>" + this.VFI_AddInfo14 + "</Sdk> </TerminalInfo> </Response>";
                break;
              }
              break;
            case 3373006507:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "L", false) == 0)
              {
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>Reprint</ResponseType> <EDCTrxNo>" + this.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + this.VFI_TransType + "</TrxType> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + this.VFI_CardSchemeName + "</CardName> <MaskedCardNo>" + this.VFI_CardNum + "</MaskedCardNo> <ECRRcptNum>" + this.VFI_ECRRcptNum + "</ECRRcptNum> <CardExpiryDate>" + this.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + this.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + this.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + this.VFI_Amount + "</TrxAmount> <Currency>" + this.VFI_DomesticCurr + "</Currency> <TrxStatus>" + this.VFI_RespCode + "</TrxStatus> <AuthCode>" + this.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + this.VFI_TransSource + "</EntryMode> <BatchNo>" + this.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + this.VFI_EMV_Label + "</APPLabel> <RRN>" + this.VFI_RRN + "</RRN>  <EMVAID>" + this.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + this.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + this.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + this.VFI_EMV_AC + "</EMVAC> <ACInfo>" + this.VFI_EMVCID + "</ACInfo> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res() + " </Response>";
                break;
              }
              break;
            case 3406561745:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "N", false) == 0)
              {
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <KeyLogOn> <ResponseType>KeyLogOn</ResponseType> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> </KeyLogOn> </Response>";
                break;
              }
              break;
            case 3456894602:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "K", false) == 0)
              {
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseType>TxnStatus</ResponseType> <EDCTrxNo>" + this.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(this.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(this.VFI_DateTime, false) + "</TrxTime> <TrxType>" + this.VFI_TransType + "</TrxType> <MID>" + this.VFI_MID + "</MID> <TID>" + this.VFI_TID + "</TID> <MerchantName>" + this.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + this.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + this.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + this.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + this.VFI_CardSchemeName + "</CardName> <MaskedCardNo>" + this.VFI_CardNum + "</MaskedCardNo> <ECRRcptNum>" + this.VFI_ECRRcptNum + "</ECRRcptNum> <CardExpiryDate>" + this.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + this.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + this.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + this.VFI_Amount + "</TrxAmount> <Currency>" + this.VFI_DomesticCurr + "</Currency> <TrxStatus>" + this.VFI_RespCode + "</TrxStatus> <AuthCode>" + this.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + this.VFI_TransSource + "</EntryMode> <BatchNo>" + this.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + this.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + this.VFI_RespMess + "</ResponseDesc> <APPVersion>" + this.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + this.VFI_EMV_Label + "</APPLabel> <RRN>" + this.VFI_RRN + "</RRN>  <EMVAID>" + this.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + this.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + this.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + this.VFI_EMV_AC + "</EMVAC> <ACInfo>" + this.VFI_EMVCID + "</ACInfo> <ErrorCode>" + this.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + this.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res() + " </Response>";
                break;
              }
              break;
            case 3641637416:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O02", false) == 0)
                break;
              break;
            case 3691970273:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O01", false) == 0)
              {
                strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <IsDCC></IsDCC> <MaxTimeout></MaxTimeout> <DCCResponse> <DCC_Details> <DCC_Local_Curr></DCC_Local_Curr> <DCC_Local_CurrCode></DCC_Local_CurrCode> <DCC_ForCurrency></DCC_ForCurrency> <DCC_ForCurrencyCode></DCC_ForCurrencyCode>  <DCC_Exchange_Rate></DCC_Exchange_Rate> <DCC_MarkUp></DCC_MarkUp> <DCC_Local_Amt></DCC_Local_Amt> <DCC_Amount></DCC_Amount> </DCC_Details> </DCCResponse> </Response>";
                this.Trace("CVFI_Imd_DCC" + Conversions.ToString(Index), this.VFI_TID);
                if (TFields.Length > checked (Index + 8))
                {
                  strMesage = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <IsDCC>1</IsDCC> <MaxTimeout>" + TFields[Index] + "</MaxTimeout> <DCCResponse> <DCC_Details> <DCC_Local_Curr>" + TFields[checked (Index + 1)] + "</DCC_Local_Curr> <DCC_Local_CurrCode>" + TFields[checked (Index + 2)] + "</DCC_Local_CurrCode> <DCC_ForCurrency>" + TFields[checked (Index + 3)] + "</DCC_ForCurrency> <DCC_ForCurrencyCode>" + TFields[checked (Index + 4)] + "</DCC_ForCurrencyCode>  <DCC_Exchange_Rate>" + TFields[checked (Index + 5)] + "</DCC_Exchange_Rate> <DCC_MarkUp>" + TFields[checked (Index + 6)] + "</DCC_MarkUp> <DCC_Local_Amt>" + TFields[checked (Index + 7)] + "</DCC_Local_Amt> <DCC_Amount>" + TFields[checked (Index + 8)] + "</DCC_Amount> </DCC_Details> </DCCResponse> </Response>";
                  break;
                }
                break;
              }
              break;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("GenerateXml error : " + exception.Message, this.VFI_TID);
        this.Trace("GenerateXml error : " + exception.ToString(), this.VFI_TID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Trace(strMesage, this.VFI_TID);
      }
      return strMesage;
    }

    private string GenerateXml(
      clsDataFields clsMem,
      string[] TFields,
      int Index,
      string strMsg,
      bool flgXml = false)
    {
      string xml = "";
      try
      {
        if (flgXml)
        {
          try
          {
            this.chkIsEPP(ref clsMem);
            this.GetTerminalInfo(ref clsMem.VFI_MerchantName, ref clsMem.VFI_Address1, ref clsMem.VFI_Address2, ref clsMem.VFI_Address3, ref clsMem.VFI_POSApplicationVersion, ref clsMem.VFI_MID);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          string str = strMsg;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
          {
            case 1708783731:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CS", false) == 0)
              {
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <POSConnection> <ResponseType></ResponseType> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> </POSConnection> </Response>";
                break;
              }
              break;
            case 3222007936:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E", false) == 0)
              {
                this.SaveInfo(clsMem.VFI_XmlRespData);
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + clsMem.VFI_XmlRespData + " <DBCount>" + clsMem.VFI_DBCount + "</DBCount> <CRCount>" + clsMem.VFI_CRCount + "</CRCount> <DBAmount>" + clsMem.VFI_DBAmount + "</DBAmount> <CRAmount>" + clsMem.VFI_CRAmount + "</CRAmount> <LHDBCount>" + clsMem.VFI_LHDBCount + "</LHDBCount> <LHCRCount>" + clsMem.VFI_LHCRCount + "</LHCRCount> <LHDBAmount>" + clsMem.VFI_LHDBAmount + "</LHDBAmount> <LHCRAmount>" + clsMem.VFI_LHCRAmount + "</LHCRAmount> <PYCDBCount>" + clsMem.VFI_PYCDBCount + "</PYCDBCount> <PYCCRCount>" + clsMem.VFI_PYCCRCount + "</PYCCRCount> <PYCDBAmount>" + clsMem.VFI_PYCDBAmount + "</PYCDBAmount> <PYCCRAmount>" + clsMem.VFI_PYCCRAmount + "</PYCCRAmount> </Response>";
                break;
              }
              break;
            case 3238785555:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "D", false) == 0)
              {
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <EDCTrxNo>" + clsMem.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(clsMem.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(clsMem.VFI_DateTime, false) + "</TrxTime> <TrxType>" + clsMem.VFI_TransType + "</TrxType> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + clsMem.VFI_CardSchemeName + "</CardName> <MaskedCardNo>" + clsMem.VFI_CardNum + "</MaskedCardNo> <ECRRcptNum>" + clsMem.VFI_ECRRcptNum + "</ECRRcptNum> <CardExpiryDate>" + clsMem.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + clsMem.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + clsMem.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + clsMem.VFI_Amount + "</TrxAmount> <Currency>" + clsMem.VFI_DomesticCurr + "</Currency> <TrxStatus>" + clsMem.VFI_RespCode + "</TrxStatus> <AuthCode>" + clsMem.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + clsMem.VFI_TransSource + "</EntryMode> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + clsMem.VFI_EMV_Label + "</APPLabel> <RRN>" + clsMem.VFI_RRN + "</RRN> <EMVAID>" + clsMem.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + clsMem.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + clsMem.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + clsMem.VFI_EMV_AC + "</EMVAC> <ACInfo>" + clsMem.VFI_EMVCID + "</ACInfo> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res(clsMem) + " </Response>";
                break;
              }
              break;
            case 3272340793:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "F", false) == 0)
              {
                this.SaveInfo(clsMem.VFI_XmlRespData);
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + clsMem.VFI_XmlRespData + " </Response>";
                break;
              }
              break;
            case 3322673650:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "C", false) == 0)
              {
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <EDCTrxNo>" + clsMem.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(clsMem.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(clsMem.VFI_DateTime, false) + "</TrxTime> <TrxType>" + clsMem.VFI_TransType + "</TrxType> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + clsMem.VFI_CardSchemeName + "</CardName> <MaskedCardNo>" + clsMem.VFI_CardNum + "</MaskedCardNo> <ECRRcptNum>" + clsMem.VFI_ECRRcptNum + "</ECRRcptNum> <CardExpiryDate>" + clsMem.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + clsMem.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + clsMem.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + clsMem.VFI_Amount + "</TrxAmount> <Currency>" + clsMem.VFI_DomesticCurr + "</Currency> <TrxStatus>" + clsMem.VFI_RespCode + "</TrxStatus> <AuthCode>" + clsMem.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + clsMem.VFI_TransSource + "</EntryMode> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + clsMem.VFI_EMV_Label + "</APPLabel> <RRN>" + clsMem.VFI_RRN + "</RRN> <EMVAID>" + clsMem.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + clsMem.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + clsMem.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + clsMem.VFI_EMV_AC + "</EMVAC> <ACInfo>" + clsMem.VFI_EMVCID + "</ACInfo> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res(clsMem) + " </Response>";
                break;
              }
              break;
            case 3356228888:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "M", false) == 0)
              {
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <TerminalInfo> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <PTID>" + clsMem.VFI_PTID + "</PTID> <SerialNo>" + clsMem.VFI_TslNo + "</SerialNo> <PartNo>" + clsMem.VFI_AddInfo1 + "</PartNo> <ApplDateTime>" + clsMem.VFI_AddInfo2 + "</ApplDateTime> <DownloadTime>" + clsMem.VFI_AddInfo3 + "</DownloadTime> <OS>" + clsMem.VFI_AddInfo4 + "</OS> <EOS>" + clsMem.VFI_AddInfo5 + "</EOS> <CTLS>" + clsMem.VFI_AddInfo6 + "</CTLS> <Application>" + clsMem.VFI_POSApplicationVersion + "</Application> <Model>" + clsMem.VFI_AddInfo7 + "</Model> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <HostIp>" + clsMem.VFI_AddInfo8 + "</HostIp> <PortNo>" + clsMem.VFI_AddInfo9 + "</PortNo> <SimIp>" + clsMem.VFI_AddInfo10 + "</SimIp> <POSTime>" + clsMem.VFI_DateTime + "</POSTime> <Nol>" + clsMem.VFI_AddInfo11 + "</Nol> <RAM>" + clsMem.VFI_AddInfo12 + "</RAM> <Flash>" + clsMem.VFI_AddInfo13 + "</Flash> <Sdk>" + clsMem.VFI_AddInfo14 + "</Sdk></TerminalInfo> </Response>";
                break;
              }
              break;
            case 3373006507:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "L", false) == 0)
              {
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <EDCTrxNo>" + clsMem.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(clsMem.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(clsMem.VFI_DateTime, false) + "</TrxTime> <TrxType>" + clsMem.VFI_TransType + "</TrxType> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + clsMem.VFI_CardSchemeName + "</CardName> <MaskedCardNo>" + clsMem.VFI_CardNum + "</MaskedCardNo> <ECRRcptNum>" + clsMem.VFI_ECRRcptNum + "</ECRRcptNum> <CardExpiryDate>" + clsMem.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + clsMem.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + clsMem.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + clsMem.VFI_Amount + "</TrxAmount> <Currency>" + clsMem.VFI_DomesticCurr + "</Currency> <TrxStatus>" + clsMem.VFI_RespCode + "</TrxStatus> <AuthCode>" + clsMem.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + clsMem.VFI_TransSource + "</EntryMode> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + clsMem.VFI_EMV_Label + "</APPLabel> <RRN>" + clsMem.VFI_RRN + "</RRN> <EMVAID>" + clsMem.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + clsMem.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + clsMem.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + clsMem.VFI_EMV_AC + "</EMVAC> <ACInfo>" + clsMem.VFI_EMVCID + "</ACInfo> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res(clsMem) + " </Response>";
                break;
              }
              break;
            case 3406561745:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "N", false) == 0)
              {
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <KeyLogOn> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> </KeyLogOn> </Response>";
                break;
              }
              break;
            case 3456894602:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "K", false) == 0)
              {
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <EDCTrxNo>" + clsMem.VFI_MessNum + "</EDCTrxNo> <TrxDate>" + this.GetDatefromDT(clsMem.VFI_DateTime, true) + "</TrxDate> <TrxTime>" + this.GetDatefromDT(clsMem.VFI_DateTime, false) + "</TrxTime> <TrxType>" + clsMem.VFI_TransType + "</TrxType> <MID>" + clsMem.VFI_MID + "</MID> <TID>" + clsMem.VFI_TID + "</TID> <MerchantName>" + clsMem.VFI_MerchantName + "</MerchantName> <MerchantAddressLine1>" + clsMem.VFI_Address1 + "</MerchantAddressLine1> <MerchantAddressLine2>" + clsMem.VFI_Address2 + "</MerchantAddressLine2> <MerchantAddressLine3>" + clsMem.VFI_Address3 + "</MerchantAddressLine3> <CardName>" + clsMem.VFI_CardSchemeName + "</CardName> <MaskedCardNo>" + clsMem.VFI_CardNum + "</MaskedCardNo> <ECRRcptNum>" + clsMem.VFI_ECRRcptNum + "</ECRRcptNum> <CardExpiryDate>" + clsMem.VFI_Expiry + "</CardExpiryDate> <CardHolderName>" + clsMem.VFI_CHName + "</CardHolderName> <CardHolderVerf>" + clsMem.VFI_CHVerification + "</CardHolderVerf> <TrxAmount>" + clsMem.VFI_Amount + "</TrxAmount> <Currency>" + clsMem.VFI_DomesticCurr + "</Currency> <TrxStatus>" + clsMem.VFI_RespCode + "</TrxStatus> <AuthCode>" + clsMem.VFI_ApprovalCode + "</AuthCode> <EntryMode>" + clsMem.VFI_TransSource + "</EntryMode> <BatchNo>" + clsMem.VFI_Batch + "</BatchNo> <IsReversed></IsReversed> <ResponseCode>" + clsMem.VFI_RespCode + "</ResponseCode> <ResponseDesc>" + clsMem.VFI_RespMess + "</ResponseDesc> <APPVersion>" + clsMem.VFI_POSApplicationVersion + "</APPVersion> <APPLabel>" + clsMem.VFI_EMV_Label + "</APPLabel> <RRN>" + clsMem.VFI_RRN + "</RRN> <EMVAID>" + clsMem.VFI_EMV_AID + "</EMVAID> <EMVTVR>" + clsMem.VFI_EMV_TVR + "</EMVTVR> <EMVTSI>" + clsMem.VFI_EMV_TSI + "</EMVTSI> <EMVAC>" + clsMem.VFI_EMV_AC + "</EMVAC> <ACInfo>" + clsMem.VFI_EMVCID + "</ACInfo> <ErrorCode>" + clsMem.VFI_FailureCode + "</ErrorCode> <ErrorDescription>" + clsMem.VFI_FailureMessage + "</ErrorDescription> " + this.Dcc_Epp_Res(clsMem) + " </Response>";
                break;
              }
              break;
            case 3641637416:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O02", false) == 0)
                break;
              break;
            case 3691970273:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O01", false) == 0)
              {
                xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <IsDCC></IsDCC> <MaxTimeout></MaxTimeout> <DCCResponse> <DCC_Details> <DCC_Local_Curr></DCC_Local_Curr> <DCC_Local_CurrCode></DCC_Local_CurrCode> <DCC_ForCurrency></DCC_ForCurrency> <DCC_ForCurrencyCode></DCC_ForCurrencyCode>  <DCC_Exchange_Rate></DCC_Exchange_Rate> <DCC_MarkUp></DCC_MarkUp> <DCC_Local_Amt></DCC_Local_Amt> <DCC_Amount></DCC_Amount> </DCC_Details> </DCCResponse> </Response>";
                if (TFields.Length > checked (Index + 8))
                {
                  xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?> <Response xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> <IsDCC>1</IsDCC> <MaxTimeout>" + TFields[Index] + "</MaxTimeout> <DCCResponse> <DCC_Details> <DCC_Local_Curr>" + TFields[checked (Index + 1)] + "</DCC_Local_Curr> <DCC_Local_CurrCode>" + TFields[checked (Index + 2)] + "</DCC_Local_CurrCode> <DCC_ForCurrency>" + TFields[checked (Index + 3)] + "</DCC_ForCurrency> <DCC_ForCurrencyCode>" + TFields[checked (Index + 4)] + "</DCC_ForCurrencyCode>  <DCC_Exchange_Rate>" + TFields[checked (Index + 5)] + "</DCC_Exchange_Rate> <DCC_MarkUp>" + TFields[checked (Index + 6)] + "</DCC_MarkUp> <DCC_Local_Amt>" + TFields[checked (Index + 7)] + "</DCC_Local_Amt> <DCC_Amount>" + TFields[checked (Index + 8)] + "</DCC_Amount> </DCC_Details> </DCCResponse> </Response>";
                  break;
                }
                break;
              }
              break;
          }
          this.Trace("strXmlData" + xml, clsMem.VFI_PTID);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Trace("GenerateXml error : " + exception.Message, clsMem.VFI_PTID);
        this.Trace("GenerateXml error : " + exception.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return xml;
    }

    private string GetDatefromDT(string strDateTime, bool flgDate)
    {
      string datefromDt;
      try
      {
        datefromDt = !flgDate ? strDateTime.Substring(8) : strDateTime.Substring(0, 8);
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      datefromDt = "";
label_3:
      return datefromDt;
    }

    private string Dcc_Epp_Res()
    {
      string str = "";
      try
      {
        this.Trace("VFI_OptOut " + this.VFI_OptOut, this.VFI_TID);
        if (this.VFI_OptOut == null)
          str = " <IsDCC>" + this.VFI_OptOut + "</IsDCC> ";
        else if (this.VFI_OptOut.Length < 1)
          str = " <IsDCC>" + this.VFI_OptOut + "</IsDCC> ";
        else if (Conversions.ToInteger(this.VFI_OptOut) < 1)
          str = " <IsDCC>" + this.VFI_OptOut + "</IsDCC> ";
        else
          str = " <IsDCC>" + this.VFI_OptOut + "</IsDCC> <DCCResponse> <DCC_Details> <DCC_ForCurrency>" + this.VFI_PYCCurrName + "</DCC_ForCurrency> <DCC_Amount>" + this.VFI_PYCAmount + "</DCC_Amount> <DCC_Local_Curr>AED</DCC_Local_Curr> <DCC_Local_Amt>" + this.VFI_Amount + "</DCC_Local_Amt> <DCC_Exchange_Rate>" + this.VFI_ExchRate + "</DCC_Exchange_Rate> <DCC_MarkUp>" + this.VFI_MarkUp + "</DCC_MarkUp> </DCC_Details> </DCCResponse> ";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.Trace("OptOut " + str, this.VFI_TID);
      try
      {
        this.Trace("VFI_Epp_Optin " + this.VFI_Epp_Optin, this.VFI_TID);
        str = this.VFI_Epp_Optin != null ? (this.VFI_Epp_Optin.Length >= 1 ? (Conversions.ToInteger(this.VFI_Epp_Optin) >= 1 ? str + " <IsEPP>" + this.VFI_Epp_Optin + "</IsEPP> <EPPResponse> <EPP_Options> <EPP_PlanID></EPP_PlanID> <EPP_PlanTenure> </EPP_PlanTenure> <EPP_Invoice> </EPP_Invoice> </EPP_Options> </EPPResponse> " : str + " <IsEPP>" + this.VFI_Epp_Optin + "</IsEPP> ") : str + " <IsEPP>" + this.VFI_Epp_Optin + "</IsEPP> ") : str + " <IsEPP>" + this.VFI_Epp_Optin + "</IsEPP> ";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.Trace("Epp_Optin " + str, this.VFI_TID);
      return str;
    }

    private string Dcc_Epp_Res(clsDataFields clsMem)
    {
      string str = "";
      try
      {
        this.Trace("Dcc_Epp_Res VFI_OptOut " + clsMem.VFI_OptOut, clsMem.VFI_PTID);
        if (clsMem.VFI_OptOut == null)
        {
          clsMem.VFI_OptOut = "0";
          str = " <IsDCC>" + clsMem.VFI_OptOut + "</IsDCC> ";
        }
        else if (clsMem.VFI_OptOut.Length < 1)
        {
          clsMem.VFI_OptOut = "0";
          str = " <IsDCC>" + clsMem.VFI_OptOut + "</IsDCC> ";
        }
        else if (Conversions.ToInteger(clsMem.VFI_OptOut) < 1)
          str = " <IsDCC>" + clsMem.VFI_OptOut + "</IsDCC> ";
        else
          str = " <IsDCC>" + clsMem.VFI_OptOut + "</IsDCC> <DCCResponse> <DCC_Details> <DCC_ForCurrency>" + clsMem.VFI_PYCCurrName + "</DCC_ForCurrency> <DCC_Amount>" + clsMem.VFI_PYCAmount + "</DCC_Amount> <DCC_Local_Curr>AED</DCC_Local_Curr> <DCC_Local_Amt>" + clsMem.VFI_Amount + "</DCC_Local_Amt> <DCC_Exchange_Rate>" + clsMem.VFI_ExchRate + "</DCC_Exchange_Rate> <DCC_MarkUp>" + clsMem.VFI_MarkUp + "</DCC_MarkUp> </DCC_Details> </DCCResponse> ";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.Trace("OptOut " + str, clsMem.VFI_PTID);
      try
      {
        this.Trace("VFI_Epp_Optin " + clsMem.VFI_Epp_Optin, clsMem.VFI_PTID);
        str = clsMem.VFI_Epp_Optin != null ? (clsMem.VFI_Epp_Optin.Length >= 1 ? (Conversions.ToInteger(clsMem.VFI_Epp_Optin) >= 1 ? str + " <IsEPP>" + clsMem.VFI_Epp_Optin + "</IsEPP> <EPPResponse> <EPP_Options> <EPP_PlanID></EPP_PlanID> <EPP_PlanTenure> </EPP_PlanTenure> <EPP_Invoice> </EPP_Invoice> </EPP_Options> </EPPResponse> " : str + " <IsEPP>" + clsMem.VFI_Epp_Optin + "</IsEPP> ") : str + " <IsEPP>" + clsMem.VFI_Epp_Optin + "</IsEPP> ") : str + " <IsEPP>" + clsMem.VFI_Epp_Optin + "</IsEPP> ";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.Trace("Epp_Optin " + str, clsMem.VFI_PTID);
      return str;
    }

    private void chkIsEPP(ref clsDataFields clsMem)
    {
      try
      {
        clsMem.VFI_Epp_Optin = "0";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void SetError(ref clsDataFields clsMem)
    {
      try
      {
        clsMem.VFI_FailureCode = clsMem.VFI_RespCode;
        clsMem.VFI_FailureMessage = clsMem.VFI_RespMess;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void chkIsEPP()
    {
      this.Trace("VFI_Epp_Optin " + this.VFI_Epp_Optin);
      try
      {
        this.VFI_Epp_Optin = "0";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.Trace("Epp_Optin " + this.VFI_Epp_Optin);
    }

    private void SetxmlResData1(ref string strMsgType)
    {
      try
      {
        if (this.VFI_XmlRespData != null && this.VFI_XmlRespData.Length >= 1)
          return;
        this.VFI_XmlRespData = this.GenerateDefaultXml(strMsgType);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("SetxmlResData Default data error : " + ex.ToString(), this.VFI_TID);
        ProjectData.ClearProjectError();
      }
    }

    private void SetxmlResData1(string strMsgType, ref clsDataFields clsMem, bool flgXml = false)
    {
      try
      {
        if (clsMem.VFI_XmlRespData != null && clsMem.VFI_XmlRespData.Length >= 1)
          return;
        clsMem.VFI_XmlRespData = this.GenerateDefaultXml(strMsgType, clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("SetxmlResData Default data error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
    }

    private void SetxmlResData(string strMsgType, ref clsDataFields clsMem, bool flgXml = false)
    {
      try
      {
        if (!flgXml)
          return;
        this.SetxmlResData1(strMsgType, ref clsMem, flgXml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("SetxmlResData Default data error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
    }

    private bool ProcessTerminalInfo(string[] TFields, ref clsDataFields clsMem)
    {
      int index1 = 1;
      bool flag;
      try
      {
        clsMem.VFI_RespCode = TFields[index1];
        int index2 = checked (index1 + 1);
        clsMem.VFI_RespMess = TFields[index2];
        int index3 = checked (index2 + 1);
        clsMem.VFI_TID = TFields[index3];
        int index4 = checked (index3 + 1);
        clsMem.VFI_MID = TFields[index4];
        int index5 = checked (index4 + 1);
        clsMem.VFI_MerchantName = TFields[index5];
        int index6 = checked (index5 + 1);
        clsMem.VFI_PTID = TFields[index6];
        int index7 = checked (index6 + 1);
        clsMem.VFI_TslNo = TFields[index7];
        int index8 = checked (index7 + 1);
        clsMem.VFI_AddInfo1 = TFields[index8];
        int index9 = checked (index8 + 1);
        clsMem.VFI_AddInfo2 = TFields[index9];
        int index10 = checked (index9 + 1);
        clsMem.VFI_AddInfo3 = TFields[index10];
        int index11 = checked (index10 + 1);
        clsMem.VFI_AddInfo4 = TFields[index11];
        int index12 = checked (index11 + 1);
        clsMem.VFI_AddInfo5 = TFields[index12];
        int index13 = checked (index12 + 1);
        clsMem.VFI_AddInfo6 = TFields[index13];
        int index14 = checked (index13 + 1);
        clsMem.VFI_POSApplicationVersion = TFields[index14];
        int index15 = checked (index14 + 1);
        clsMem.VFI_AddInfo7 = TFields[index15];
        int index16 = checked (index15 + 1);
        clsMem.VFI_Batch = TFields[index16];
        int index17 = checked (index16 + 1);
        clsMem.VFI_AddInfo8 = TFields[index17];
        int index18 = checked (index17 + 1);
        clsMem.VFI_AddInfo9 = TFields[index18];
        int index19 = checked (index18 + 1);
        clsMem.VFI_AddInfo10 = TFields[index19];
        int index20 = checked (index19 + 1);
        clsMem.VFI_DateTime = TFields[index20];
        int index21 = checked (index20 + 1);
        clsMem.VFI_AddInfo11 = TFields[index21];
        int index22 = checked (index21 + 1);
        clsMem.VFI_AddInfo12 = TFields[index22];
        int index23 = checked (index22 + 1);
        clsMem.VFI_AddInfo13 = TFields[index23];
        int num = checked (index23 + 1);
        if (this.flgEnc)
          this.Trace(string.Format("MID:{0},TID:{1},Date:{2},MerName:{3},PTID:{4},SN:{5},AppVer:{6},ResCode:{7},Message:{8},Batch:{9},AddInfo1:{11},AddInfo2{12},AddInfo3{13},AddInfo4{14},AddInfo5{15},AddInfo6{16},AddInfo7{17},AddInfo8{18},AddInfo9{19},AddInfo10{20},AddInfo11{21},AddInfo12{22},AddInfo13{10} ", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_DateTime, (object) clsMem.VFI_MerchantName, (object) clsMem.VFI_PTID, (object) clsMem.VFI_TslNo, (object) clsMem.VFI_POSApplicationVersion, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_Batch, (object) clsMem.VFI_AddInfo1, (object) clsMem.VFI_AddInfo2, (object) clsMem.VFI_AddInfo3, (object) clsMem.VFI_AddInfo4, (object) clsMem.VFI_AddInfo5, (object) clsMem.VFI_AddInfo6, (object) clsMem.VFI_AddInfo7, (object) clsMem.VFI_AddInfo8, (object) clsMem.VFI_AddInfo9, (object) clsMem.VFI_AddInfo10, (object) clsMem.VFI_AddInfo11, (object) clsMem.VFI_AddInfo12, (object) clsMem.VFI_AddInfo13), clsMem.VFI_PTID);
        flag = true;
        goto label_6;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Process Block error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_6:
      return flag;
    }

    private bool ProcessReprint(string[] TFields, ref clsDataFields clsMem)
    {
      bool flag;
      try
      {
        this.ProcessGetAuthData(TFields, 1, ref clsMem);
        flag = true;
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Process Block error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_3:
      return flag;
    }

    private bool ProcessDCCSelection(string[] TFields, ref clsDataFields clsMem)
    {
      int index1 = 1;
      bool flag;
      try
      {
        if (TFields.Length > checked (index1 + 1))
        {
          clsMem.VFI_AddInfo1 = TFields[index1];
          int index2 = checked (index1 + 1);
          if (TFields.Length > checked (index2 + 1))
          {
            clsMem.VFI_AddInfo2 = TFields[index2];
            int index3 = checked (index2 + 1);
            if (TFields.Length > checked (index3 + 1))
            {
              clsMem.VFI_AddInfo3 = TFields[index3];
              int index4 = checked (index3 + 1);
              if (TFields.Length > checked (index4 + 1))
              {
                clsMem.VFI_AddInfo4 = TFields[index4];
                int index5 = checked (index4 + 1);
                if (TFields.Length > checked (index5 + 1))
                {
                  clsMem.VFI_AddInfo5 = TFields[index5];
                  int index6 = checked (index5 + 1);
                  if (TFields.Length > checked (index6 + 1))
                  {
                    clsMem.VFI_AddInfo6 = TFields[index6];
                    int index7 = checked (index6 + 1);
                    if (TFields.Length > checked (index7 + 1))
                    {
                      clsMem.VFI_AddInfo7 = TFields[index7];
                      int index8 = checked (index7 + 1);
                      if (TFields.Length > checked (index8 + 1))
                      {
                        clsMem.VFI_AddInfo8 = TFields[index8];
                        int index9 = checked (index8 + 1);
                        if (TFields.Length > checked (index9 + 1))
                        {
                          clsMem.VFI_AddInfo9 = TFields[index9];
                          int index10 = checked (index9 + 1);
                          if (TFields.Length > checked (index10 + 1))
                          {
                            clsMem.VFI_AddInfo10 = TFields[index10];
                            int num = checked (index10 + 1);
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        flag = true;
        goto label_15;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Process Block error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_15:
      return flag;
    }

    private bool ProcessLogOn(string[] TFields, ref clsDataFields clsMem)
    {
      int index1 = 1;
      bool flag;
      try
      {
        clsMem.VFI_RespCode = TFields[index1];
        int index2 = checked (index1 + 1);
        clsMem.VFI_RespMess = TFields[index2];
        int index3 = checked (index2 + 1);
        if (this.flgEnc)
          this.Trace(string.Format("RespCode{0},RespMess{1}, ", (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess), clsMem.VFI_PTID);
        if (TFields.Length > checked (index3 + 1))
        {
          clsMem.VFI_AddInfo1 = TFields[index3];
          int index4 = checked (index3 + 1);
          if (TFields.Length > checked (index4 + 1))
          {
            clsMem.VFI_AddInfo2 = TFields[index4];
            int index5 = checked (index4 + 1);
            if (TFields.Length > checked (index5 + 1))
            {
              clsMem.VFI_AddInfo3 = TFields[index5];
              int index6 = checked (index5 + 1);
              if (TFields.Length > checked (index6 + 1))
              {
                clsMem.VFI_AddInfo4 = TFields[index6];
                int index7 = checked (index6 + 1);
                if (TFields.Length > checked (index7 + 1))
                {
                  clsMem.VFI_AddInfo5 = TFields[index7];
                  int index8 = checked (index7 + 1);
                  if (TFields.Length > checked (index8 + 1))
                  {
                    clsMem.VFI_AddInfo6 = TFields[index8];
                    int index9 = checked (index8 + 1);
                    if (TFields.Length > checked (index9 + 1))
                    {
                      clsMem.VFI_AddInfo7 = TFields[index9];
                      int index10 = checked (index9 + 1);
                      if (TFields.Length > checked (index10 + 1))
                      {
                        clsMem.VFI_AddInfo8 = TFields[index10];
                        int index11 = checked (index10 + 1);
                        if (TFields.Length > checked (index11 + 1))
                        {
                          clsMem.VFI_AddInfo9 = TFields[index11];
                          int index12 = checked (index11 + 1);
                          if (TFields.Length > checked (index12 + 1))
                          {
                            clsMem.VFI_AddInfo10 = TFields[index12];
                            int num = checked (index12 + 1);
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        flag = true;
        goto label_17;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Process Block error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_17:
      return flag;
    }

    private bool ProcessTidMid(string[] TFields, ref clsDataFields clsMem)
    {
      int index1 = 1;
      bool flag;
      try
      {
        clsMem.VFI_RespCode = TFields[index1];
        int index2 = checked (index1 + 1);
        clsMem.VFI_RespMess = TFields[index2];
        int index3 = checked (index2 + 1);
        clsMem.VFI_TID = TFields[index3];
        int index4 = checked (index3 + 1);
        clsMem.VFI_MID = TFields[index4];
        int index5 = checked (index4 + 1);
        if (this.flgEnc)
          this.Trace(string.Format("MID:{0},TID:{1},ResCode:{2},Message:{3} ", (object) clsMem.VFI_MID, (object) clsMem.VFI_TID, (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess), clsMem.VFI_PTID);
        if (TFields.Length > checked (index5 + 1))
        {
          clsMem.VFI_AddInfo1 = TFields[index5];
          int index6 = checked (index5 + 1);
          if (TFields.Length > checked (index6 + 1))
          {
            clsMem.VFI_AddInfo2 = TFields[index6];
            int index7 = checked (index6 + 1);
            if (TFields.Length > checked (index7 + 1))
            {
              clsMem.VFI_AddInfo3 = TFields[index7];
              int index8 = checked (index7 + 1);
              if (TFields.Length > checked (index8 + 1))
              {
                clsMem.VFI_AddInfo4 = TFields[index8];
                int index9 = checked (index8 + 1);
                if (TFields.Length > checked (index9 + 1))
                {
                  clsMem.VFI_AddInfo5 = TFields[index9];
                  int index10 = checked (index9 + 1);
                  if (TFields.Length > checked (index10 + 1))
                  {
                    clsMem.VFI_AddInfo6 = TFields[index10];
                    int index11 = checked (index10 + 1);
                    if (TFields.Length > checked (index11 + 1))
                    {
                      clsMem.VFI_AddInfo7 = TFields[index11];
                      int index12 = checked (index11 + 1);
                      if (TFields.Length > checked (index12 + 1))
                      {
                        clsMem.VFI_AddInfo8 = TFields[index12];
                        int index13 = checked (index12 + 1);
                        if (TFields.Length > checked (index13 + 1))
                        {
                          clsMem.VFI_AddInfo9 = TFields[index13];
                          int index14 = checked (index13 + 1);
                          if (TFields.Length > checked (index14 + 1))
                          {
                            clsMem.VFI_AddInfo10 = TFields[index14];
                            int num = checked (index14 + 1);
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        flag = true;
        goto label_17;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Process Block error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_17:
      return flag;
    }

    private bool ProcessReportData(string[] TFields, ref clsDataFields clsMem)
    {
      int index1 = 1;
      bool flag;
      try
      {
        clsMem.VFI_RespCode = TFields[index1];
        int index2 = checked (index1 + 1);
        clsMem.VFI_RespMess = TFields[index2];
        int index3 = checked (index2 + 1);
        clsMem.VFI_DBCount = TFields[index3];
        int index4 = checked (index3 + 1);
        clsMem.VFI_CRCount = TFields[index4];
        int index5 = checked (index4 + 1);
        clsMem.VFI_DBAmount = TFields[index5];
        int index6 = checked (index5 + 1);
        clsMem.VFI_CRAmount = TFields[index6];
        int index7 = checked (index6 + 1);
        clsMem.VFI_TID = TFields[index7];
        int index8 = checked (index7 + 1);
        clsMem.VFI_Batch = TFields[index8];
        int index9 = checked (index8 + 1);
        clsMem.VFI_MID = TFields[index9];
        int index10 = checked (index9 + 1);
        if (this.VerifyMAC(TFields[index10], TFields[checked (index10 + 1)]))
        {
          if (this.flgEnc)
            this.Trace(string.Format("DBCount{2},DBAmount{3},CRCount{4},CRAmount{5},TID{6},Batch{7},MID{8},RespCode{0},RespMess{1}, ", (object) clsMem.VFI_RespCode, (object) clsMem.VFI_RespMess, (object) clsMem.VFI_DBCount, (object) clsMem.VFI_DBAmount, (object) clsMem.VFI_CRCount, (object) clsMem.VFI_CRAmount, (object) clsMem.VFI_TID, (object) clsMem.VFI_Batch, (object) clsMem.VFI_MID), clsMem.VFI_PTID);
          flag = true;
          goto label_7;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        clsMem.VFI_RespCode = "Z9";
        clsMem.VFI_RespMess = exception.Message;
        this.Trace("Process Block error : " + clsMem.VFI_RespMess, clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      flag = false;
label_7:
      return flag;
    }

    public bool VFI_SelectedDCCOffer(string TerminalId, string RespCode, string DCC_OptIn)
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = TerminalId;
        clsMem.VFI_AddInInfo1 = RespCode;
        clsMem.VFI_OptOut = DCC_OptIn;
        clsMem = this.VFI_SelectedDCCOffer(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_SelectedDCCOffer error 1 : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      try
      {
        this.SetResData(clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_SelectedDCCOffer error 2 : " + ex.ToString(), TerminalId);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_SelectedDCCOffer()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_AddInInfo1 = this.VFI_RespCode;
        clsMem.VFI_OptOut = this.VFI_OptOut;
        clsMem = this.VFI_SelectedDCCOffer(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_SelectedDCCOffer error 1 : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      try
      {
        this.SetResData(clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_SelectedDCCOffer error 2 : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_TxnStatus(string TerminalID, string ECRRcptNum)
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_ECRRcptNum = ECRRcptNum;
        clsMem = this.VFI_TxnStatus(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_TxnStatus error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_TxnStatus()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_ECRRcptNum = this.VFI_ECRRcptNum;
        clsMem = this.VFI_TxnStatus(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_TxnStatus error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_GetReprint(string TerminalId, string MessNum)
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = TerminalId;
        clsMem.VFI_OrgionalRcptNum = MessNum;
        clsMem = this.VFI_GetReprint(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetReprint error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_GetReprint()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_OrgionalRcptNum = this.VFI_MessNum;
        clsMem = this.VFI_GetReprint(clsMem, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetReprint error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_GetTerminalInfo()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = "";
        clsMem = this.VFI_GetTerminalInfo(clsMem, false);
        this.SetResData(clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetTerminalInfo error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_KeyLogOn()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = "";
        clsMem = this.VFI_KeyLogOn(clsMem, true);
        this.SetResData(clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_KeyLogOn error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public bool VFI_GetTidMid()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = "";
        clsMem = this.VFI_GetTidMid(clsMem, true);
        this.SetResData(clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_GetTidMid error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    public string VFI_Report(string TerminalID, string ReportType)
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = TerminalID;
        clsMem.VFI_ReportType = ReportType;
        clsMem = this.VFI_Report(clsMem, true);
        this.SetResData(clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Report error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.SetxmlResData("F", ref clsMem);
      }
      return clsMem.VFI_XmlRespData;
    }

    public bool VFI_Report()
    {
      clsDataFields clsMem = new clsDataFields();
      try
      {
        clsMem.VFI_TID = this.VFI_TID;
        clsMem.VFI_ReportType = this.VFI_ReportType;
        clsMem = this.VFI_Report(clsMem, true);
        this.SetResData(clsMem);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Trace("VFI_Report error : " + ex.ToString(), clsMem.VFI_PTID);
        ProjectData.ClearProjectError();
      }
      return clsMem.FunctionStatus;
    }

    ~comCMXECR() => base.Finalize();

    private class MsgType
    {
      public const string CVFI_InitTrans = "A";
      public const string CVFI_ResetMAC = "B";
      public const string CVFI_GetMaskedCardNo = "B";
      public const string CVFI_GetAuth = "C";
      public const string CVFI_VoidTrans = "D";
      public const string CVFI_Settle = "E";
      public const string CVFI_Report = "F";
      public const string CVFI_Instruction = "G";
      public const string CVFI_PIETxn = "H";
      public const string CVFI_Restart = "I";
      public const string CVFI_PingHost = "J";
      public const string CVFI_Error = "Z";
      public const string CVFI_TxnStatus = "K";
      public const string CVFI_Reprint = "L";
      public const string CVFI_TerminalInfo = "M";
      public const string CVFI_KeyLogOn = "N";
      public const string CVFI_Imd_DCC = "O01";
      public const string CVFI_Imd_RptFile = "O02";
      public const string CVFI_GetTidMid = "P";
    }

    public enum Results : short
    {
      CVFI_ECRRcptNum = 1,
      CVFI_TransType = 2,
      CVFI_Amount = 3,
      CVFI_CashAmount = 4,
      CVFI_CardNum = 5,
      CVFI_Expiry = 6,
      CVFI_CHName = 7,
      CVFI_MessNum = 8,
      CVFI_CardSchemeName = 9,
      CVFI_TransSource = 10, // 0x000A
      CVFI_AuthMode = 11, // 0x000B
      CVFI_CHVerification = 12, // 0x000C
      CVFI_RespCode = 13, // 0x000D
      CVFI_RespMess = 14, // 0x000E
      CVFI_ApprovalCode = 15, // 0x000F
      CVFI_DateTime = 16, // 0x0010
      CVFI_EMV_Label = 17, // 0x0011
      CVFI_EMV_AID = 18, // 0x0012
      CVFI_EMV_TVR = 19, // 0x0013
      CVFI_EMV_TSI = 20, // 0x0014
      CVFI_EMV_AC = 21, // 0x0015
      CVFI_TIPAmount = 22, // 0x0016
      CVFI_PreauthComplAmount = 23, // 0x0017
      CVFI_PreauthApprovalCode = 24, // 0x0018
      CVFI_PreRcptNum = 25, // 0x0019
      CVFI_VoidReceiptNum = 26, // 0x001A
      CVFI_DBCount = 27, // 0x001B
      CVFI_CRCount = 28, // 0x001C
      CVFI_DBAmount = 29, // 0x001D
      CVFI_CRAmount = 30, // 0x001E
      CVFI_AdditionalInfo = 31, // 0x001F
      CVFI_ReportType = 32, // 0x0020
      CVFI_TID = 33, // 0x0021
      CVFI_Batch = 34, // 0x0022
      CVFI_MacSourceData = 35, // 0x0023
      CVFI_MAC = 36, // 0x0024
      CVFI_EMVCID = 37, // 0x0025
      CVFI_ExchRate = 38, // 0x0026
      CVFI_PYCAmount = 39, // 0x0027
      CVFI_MarkUp = 40, // 0x0028
      CVFI_PYCCurr = 41, // 0x0029
      CVFI_PYCCurrName = 42, // 0x002A
      CVFI_OptOut = 43, // 0x002B
      CVFI_QPSVeps = 44, // 0x002C
      CVFI_RRN = 45, // 0x002D
      CVFI_DccHost = 46, // 0x002E
      CVFI_Length = 46, // 0x002E
    }

    public enum TxnType : short
    {
      CVFI_SALE = 1,
      CVFI_PREAUTH = 2,
      CVFI_CASHADV = 3,
      CVFI_CASHBACK = 4,
      CVFI_TIP = 5,
      CVFI_REFUND = 6,
    }

    private class Msg_Type
    {
      public const string CVFI_Purchase = "01";
      public const string CVFI_Reversal = "02";
      public const string CVFI_Balance = "03";
      public const string CVFI_Reissue = "04";
      public const string CVFI_Refund = "05";
      public const string CVFI_Last5Txn = "06";
    }

    public delegate void getPOSCurrentInstructionEventHandler(string strCurrentInstruction);

    internal struct Setting
    {
      public short Timeout;
      public short TxnTimeout;
      public string TracePath;
      public short UploadTimeout;
      public bool Trace;
      public string PortName;
      public int BaudRate;
      public bool Delay;
      public short DelayTimeout;
      public string LICData;
      public bool flgAPACS;
      public bool flgWaitRes;
      public bool flgTxnLog;
      public bool flgDoEvent;
      public int SleepTime;
      public bool DtrRts;
    }

    [Guid("72fe1453-1651-4ac3-9fd2-d756f3342523")]
    [ComVisible(true)]
    public interface _comCMXECR
    {
      [DispId(1)]
      void Install();

      [DispId(2)]
      void Uninstall();

      [DispId(3)]
      bool VFI_InitializeAll();

      [DispId(4)]
      string VFI_GetFieldValue(short FieldID);

      [DispId(5)]
      bool VFI_LoadSetting();

      [DispId(6)]
      bool VFI_DoSetup();

      [DispId(7)]
      bool VFI_DoSetup(ref string RespCode, ref string RespMess);

      [DispId(8)]
      bool VFI_SetFieldValue(short FieldID, string TValue);

      [DispId(9)]
      bool VFI_GetAuth();

      [DispId(10)]
      bool VFI_VoidTrans();

      [DispId(11)]
      bool VFI_Settle();

      [DispId(12)]
      bool VFI_GetMaskedCardNo();

      [DispId(13)]
      bool VFI_GetAuth(
        string TransType,
        string Amount,
        string CashAmount,
        string AdditionalInfo,
        string ECRRcptNum,
        ref string RespCode,
        ref string RespMess);

      [DispId(14)]
      bool VFI_VoidTrans(
        string Amount,
        string VoidReceiptNum,
        string CashAmount,
        string ECRRcptNum,
        string AdditionalInfo,
        ref string RespCode,
        ref string RespMess,
        string OptInOut);

      [DispId(15)]
      bool VFI_Settle(ref string RespCode, ref string RespMess);

      [DispId(16)]
      bool SaveSettings(
        string PortNo,
        int BaudRate,
        int Timeout,
        int TxnTimeout,
        int UploadTimeout,
        string TracePath,
        bool flgTrace,
        bool Delay,
        int DelayTimeout,
        bool APACS,
        bool WaitMessge,
        bool TxnLog);

      [DispId(17)]
      bool GetSettings(
        ref string PortNo,
        ref int BaudRate,
        ref short Timeout,
        ref int TxnTimeout,
        ref int UploadTimeout,
        ref string TracePath,
        ref bool flgTrace,
        ref bool Delay,
        ref short DelayTimeout,
        ref bool DCC,
        ref bool WaitMessge,
        ref bool TxnLog);

      [DispId(18)]
      string VFI_AboutDll();

      [DispId(19)]
      void Dispose();

      [DispId(20)]
      string GetSet_VFI_ECRRcptNum { [DispId(20)] get; [DispId(20)] set; }

      [DispId(21)]
      string GetSet_VFI_TransType { [DispId(21)] get; [DispId(21)] set; }

      [DispId(22)]
      string GetSet_VFI_Amount { [DispId(22)] get; [DispId(22)] set; }

      [DispId(23)]
      string GetSet_VFI_CashAmount { [DispId(23)] get; [DispId(23)] set; }

      [DispId(24)]
      string GetSet_VFI_CardNum { [DispId(24)] get; }

      [DispId(25)]
      string GetSet_VFI_Expiry { [DispId(25)] get; }

      [DispId(26)]
      string GetSet_VFI_CHName { [DispId(26)] get; }

      [DispId(27)]
      string GetSet_VFI_MessNum { [DispId(27)] get; [DispId(27)] set; }

      [DispId(28)]
      string GetSet_VFI_CardSchemeName { [DispId(28)] get; }

      [DispId(29)]
      string GetSet_VFI_TransSource { [DispId(29)] get; }

      [DispId(30)]
      string GetSet_VFI_AuthMode { [DispId(30)] get; }

      [DispId(31)]
      string GetSet_VFI_CHVerification { [DispId(31)] get; }

      [DispId(32)]
      string GetSet_VFI_RespCode { [DispId(32)] get; }

      [DispId(33)]
      string GetSet_VFI_RespMess { [DispId(33)] get; }

      [DispId(34)]
      string GetSet_VFI_ApprovalCode { [DispId(34)] get; [DispId(34)] set; }

      [DispId(35)]
      string GetSet_VFI_DateTime { [DispId(35)] get; }

      [DispId(36)]
      string GetSet_VFI_EMV_Label { [DispId(36)] get; }

      [DispId(37)]
      string GetSet_VFI_EMV_AID { [DispId(37)] get; }

      [DispId(38)]
      string GetSet_VFI_EMV_TVR { [DispId(38)] get; }

      [DispId(39)]
      string GetSet_VFI_EMV_TSI { [DispId(39)] get; }

      [DispId(40)]
      string GetSet_VFI_EMV_AC { [DispId(40)] get; }

      [DispId(41)]
      string GetSet_VFI_VoidReceiptNum { [DispId(41)] get; [DispId(41)] set; }

      [DispId(42)]
      string GetSet_VFI_DBCount { [DispId(42)] get; }

      [DispId(43)]
      string GetSet_VFI_DBAmount { [DispId(43)] get; }

      [DispId(44)]
      string GetSet_VFI_CRCount { [DispId(44)] get; }

      [DispId(45)]
      string GetSet_VFI_CRAmount { [DispId(45)] get; }

      [DispId(46)]
      string GetSet_VFI_PYCDBCount { [DispId(46)] get; }

      [DispId(47)]
      string GetSet_VFI_PYCDBAmount { [DispId(47)] get; }

      [DispId(48)]
      string GetSet_VFI_PYCCRCount { [DispId(48)] get; }

      [DispId(49)]
      string GetSet_VFI_PYCCRAmount { [DispId(49)] get; }

      [DispId(50)]
      string GetSet_VFI_LHDBCount { [DispId(50)] get; }

      [DispId(51)]
      string GetSet_VFI_LHDBAmount { [DispId(51)] get; }

      [DispId(52)]
      string GetSet_VFI_LHCRCount { [DispId(52)] get; }

      [DispId(53)]
      string GetSet_VFI_LHCRAmount { [DispId(53)] get; }

      [DispId(54)]
      string GetSet_VFI_AdditionalInfo { [DispId(54)] get; [DispId(54)] set; }

      [DispId(55)]
      string GetSet_VFI_TID { [DispId(55)] get; [DispId(55)] set; }

      [DispId(56)]
      string GetSet_VFI_MID { [DispId(56)] get; [DispId(56)] set; }

      [DispId(57)]
      string GetSet_VFI_Batch { [DispId(57)] get; }

      [DispId(58)]
      string GetSet_VFI_EMVCID { [DispId(58)] get; }

      [DispId(59)]
      string GetSet_VFI_ExchRate { [DispId(59)] get; }

      [DispId(60)]
      string GetSet_VFI_PYCAmount { [DispId(60)] get; }

      [DispId(61)]
      string GetSet_VFI_MarkUp { [DispId(61)] get; }

      [DispId(62)]
      string GetSet_VFI_PYCCurr { [DispId(62)] get; }

      [DispId(63)]
      string GetSet_VFI_PYCCurrName { [DispId(63)] get; }

      [DispId(64)]
      string GetSet_VFI_OptOut { [DispId(64)] get; [DispId(64)] set; }

      [DispId(65)]
      string GetSet_CurrentInstruction { [DispId(65)] get; }

      [DispId(66)]
      string GetSet_VFI_Card_First7 { [DispId(66)] get; [DispId(66)] set; }

      [DispId(67)]
      string GetSet_VFI_Card_last4 { [DispId(67)] get; [DispId(67)] set; }

      [DispId(68)]
      string GetSet_VFI_CardTypes { [DispId(68)] get; }

      [DispId(69)]
      string GetSet_VFI_DccCardTypes { [DispId(69)] get; }

      [DispId(70)]
      string GetSet_VFI_CardType0_CardName { [DispId(70)] get; }

      [DispId(71)]
      string GetSet_VFI_CardType0_DBCount { [DispId(71)] get; }

      [DispId(72)]
      string GetSet_VFI_CardType0_DBAmount { [DispId(72)] get; }

      [DispId(73)]
      string GetSet_VFI_CardType0_CRCount { [DispId(73)] get; }

      [DispId(74)]
      string GetSet_VFI_CardType0_CRAmount { [DispId(74)] get; }

      [DispId(75)]
      string GetSet_VFI_CardType1_CardName { [DispId(75)] get; }

      [DispId(76)]
      string GetSet_VFI_CardType1_DBCount { [DispId(76)] get; }

      [DispId(77)]
      string GetSet_VFI_CardType1_DBAmount { [DispId(77)] get; }

      [DispId(78)]
      string GetSet_VFI_CardType1_CRCount { [DispId(78)] get; }

      [DispId(79)]
      string GetSet_VFI_CardType1_CRAmount { [DispId(79)] get; }

      [DispId(80)]
      string GetSet_VFI_CardType2_CardName { [DispId(80)] get; }

      [DispId(81)]
      string GetSet_VFI_CardType2_DBCount { [DispId(81)] get; }

      [DispId(82)]
      string GetSet_VFI_CardType2_DBAmount { [DispId(82)] get; }

      [DispId(83)]
      string GetSet_VFI_CardType2_CRCount { [DispId(83)] get; }

      [DispId(84)]
      string GetSet_VFI_CardType2_CRAmount { [DispId(84)] get; }

      [DispId(85)]
      string GetSet_VFI_CardType3_CardName { [DispId(85)] get; }

      [DispId(86)]
      string GetSet_VFI_CardType3_DBCount { [DispId(86)] get; }

      [DispId(87)]
      string GetSet_VFI_CardType3_DBAmount { [DispId(87)] get; }

      [DispId(88)]
      string GetSet_VFI_CardType3_CRCount { [DispId(88)] get; }

      [DispId(89)]
      string GetSet_VFI_CardType3_CRAmount { [DispId(89)] get; }

      [DispId(90)]
      string GetSet_VFI_CardType4_CardName { [DispId(90)] get; }

      [DispId(91)]
      string GetSet_VFI_CardType4_DBCount { [DispId(91)] get; }

      [DispId(92)]
      string GetSet_VFI_CardType4_DBAmount { [DispId(92)] get; }

      [DispId(93)]
      string GetSet_VFI_CardType4_CRCount { [DispId(93)] get; }

      [DispId(94)]
      string GetSet_VFI_CardType4_CRAmount { [DispId(94)] get; }

      [DispId(95)]
      string GetSet_VFI_CardType5_CardName { [DispId(95)] get; }

      [DispId(96)]
      string GetSet_VFI_CardType5_DBCount { [DispId(96)] get; }

      [DispId(97)]
      string GetSet_VFI_CardType5_DBAmount { [DispId(97)] get; }

      [DispId(98)]
      string GetSet_VFI_CardType5_CRCount { [DispId(98)] get; }

      [DispId(99)]
      string GetSet_VFI_CardType5_CRAmount { [DispId(99)] get; }

      [DispId(100)]
      string GetSet_VFI_CardType6_CardName { [DispId(100)] get; }

      [DispId(101)]
      string GetSet_VFI_CardType6_DBCount { [DispId(101)] get; }

      [DispId(102)]
      string GetSet_VFI_CardType6_DBAmount { [DispId(102)] get; }

      [DispId(103)]
      string GetSet_VFI_CardType6_CRCount { [DispId(103)] get; }

      [DispId(104)]
      string GetSet_VFI_CardType6_CRAmount { [DispId(104)] get; }

      [DispId(105)]
      string GetSet_VFI_CardType7_CardName { [DispId(105)] get; }

      [DispId(106)]
      string GetSet_VFI_CardType7_DBCount { [DispId(106)] get; }

      [DispId(107)]
      string GetSet_VFI_CardType7_DBAmount { [DispId(107)] get; }

      [DispId(108)]
      string GetSet_VFI_CardType7_CRCount { [DispId(108)] get; }

      [DispId(109)]
      string GetSet_VFI_CardType7_CRAmount { [DispId(109)] get; }

      [DispId(110)]
      string GetSet_VFI_CardType8_CardName { [DispId(110)] get; }

      [DispId(111)]
      string GetSet_VFI_CardType8_DBCount { [DispId(111)] get; }

      [DispId(112)]
      string GetSet_VFI_CardType8_DBAmount { [DispId(112)] get; }

      [DispId(113)]
      string GetSet_VFI_CardType8_CRCount { [DispId(113)] get; }

      [DispId(114)]
      string GetSet_VFI_CardType8_CRAmount { [DispId(114)] get; }

      [DispId(115)]
      string GetSet_VFI_CardType9_CardName { [DispId(115)] get; }

      [DispId(116)]
      string GetSet_VFI_CardType9_DBCount { [DispId(116)] get; }

      [DispId(117)]
      string GetSet_VFI_CardType9_DBAmount { [DispId(117)] get; }

      [DispId(118)]
      string GetSet_VFI_CardType9_CRCount { [DispId(118)] get; }

      [DispId(119)]
      string GetSet_VFI_CardType9_CRAmount { [DispId(119)] get; }

      [DispId(120)]
      string GetSet_VFI_DccCardType0_CardName { [DispId(120)] get; }

      [DispId(121)]
      string GetSet_VFI_DccCardType0_DBCount { [DispId(121)] get; }

      [DispId(122)]
      string GetSet_VFI_DccCardType0_DBAmount { [DispId(122)] get; }

      [DispId(123)]
      string GetSet_VFI_DccCardType0_CRCount { [DispId(123)] get; }

      [DispId(124)]
      string GetSet_VFI_DccCardType0_CRAmount { [DispId(124)] get; }

      [DispId(125)]
      string GetSet_VFI_DccCardType1_CardName { [DispId(125)] get; }

      [DispId(126)]
      string GetSet_VFI_DccCardType1_DBCount { [DispId(126)] get; }

      [DispId(127)]
      string GetSet_VFI_DccCardType1_DBAmount { [DispId(127)] get; }

      [DispId(128)]
      string GetSet_VFI_DccCardType1_CRCount { [DispId(128)] get; }

      [DispId(129)]
      string GetSet_VFI_DccCardType1_CRAmount { [DispId(129)] get; }

      [DispId(130)]
      string GetSet_VFI_DccCardType2_CardName { [DispId(130)] get; }

      [DispId(131)]
      string GetSet_VFI_DccCardType2_DBCount { [DispId(131)] get; }

      [DispId(132)]
      string GetSet_VFI_DccCardType2_DBAmount { [DispId(132)] get; }

      [DispId(133)]
      string GetSet_VFI_DccCardType2_CRCount { [DispId(133)] get; }

      [DispId(134)]
      string GetSet_VFI_DccCardType2_CRAmount { [DispId(134)] get; }

      [DispId(135)]
      string GetSet_VFI_DccCardType3_CardName { [DispId(135)] get; }

      [DispId(136)]
      string GetSet_VFI_DccCardType3_DBCount { [DispId(136)] get; }

      [DispId(137)]
      string GetSet_VFI_DccCardType3_DBAmount { [DispId(137)] get; }

      [DispId(138)]
      string GetSet_VFI_DccCardType3_CRCount { [DispId(138)] get; }

      [DispId(139)]
      string GetSet_VFI_DccCardType3_CRAmount { [DispId(139)] get; }

      [DispId(140)]
      string GetSet_VFI_DccCardType4_CardName { [DispId(140)] get; }

      [DispId(141)]
      string GetSet_VFI_DccCardType4_DBCount { [DispId(141)] get; }

      [DispId(142)]
      string GetSet_VFI_DccCardType4_DBAmount { [DispId(142)] get; }

      [DispId(143)]
      string GetSet_VFI_DccCardType4_CRCount { [DispId(143)] get; }

      [DispId(144)]
      string GetSet_VFI_DccCardType4_CRAmount { [DispId(144)] get; }

      [DispId(145)]
      string GetSet_VFI_DccCardType5_CardName { [DispId(145)] get; }

      [DispId(146)]
      string GetSet_VFI_DccCardType5_DBCount { [DispId(146)] get; }

      [DispId(147)]
      string GetSet_VFI_DccCardType5_DBAmount { [DispId(147)] get; }

      [DispId(148)]
      string GetSet_VFI_DccCardType5_CRCount { [DispId(148)] get; }

      [DispId(149)]
      string GetSet_VFI_DccCardType5_CRAmount { [DispId(149)] get; }

      [DispId(150)]
      string GetSet_VFI_DccCardType6_CardName { [DispId(150)] get; }

      [DispId(151)]
      string GetSet_VFI_DccCardType6_DBCount { [DispId(151)] get; }

      [DispId(152)]
      string GetSet_VFI_DccCardType6_DBAmount { [DispId(152)] get; }

      [DispId(153)]
      string GetSet_VFI_DccCardType6_CRCount { [DispId(153)] get; }

      [DispId(154)]
      string GetSet_VFI_DccCardType6_CRAmount { [DispId(154)] get; }

      [DispId(155)]
      string GetSet_VFI_DccCardType7_CardName { [DispId(155)] get; }

      [DispId(156)]
      string GetSet_VFI_DccCardType7_DBCount { [DispId(156)] get; }

      [DispId(157)]
      string GetSet_VFI_DccCardType7_DBAmount { [DispId(157)] get; }

      [DispId(158)]
      string GetSet_VFI_DccCardType7_CRCount { [DispId(158)] get; }

      [DispId(159)]
      string GetSet_VFI_DccCardType7_CRAmount { [DispId(159)] get; }

      [DispId(160)]
      string GetSet_VFI_DccCardType8_CardName { [DispId(160)] get; }

      [DispId(161)]
      string GetSet_VFI_DccCardType8_DBCount { [DispId(161)] get; }

      [DispId(162)]
      string GetSet_VFI_DccCardType8_DBAmount { [DispId(162)] get; }

      [DispId(163)]
      string GetSet_VFI_DccCardType8_CRCount { [DispId(163)] get; }

      [DispId(164)]
      string GetSet_VFI_DccCardType8_CRAmount { [DispId(164)] get; }

      [DispId(165)]
      string GetSet_VFI_DccCardType9_CardName { [DispId(165)] get; }

      [DispId(166)]
      string GetSet_VFI_DccCardType9_DBCount { [DispId(166)] get; }

      [DispId(167)]
      string GetSet_VFI_DccCardType9_DBAmount { [DispId(167)] get; }

      [DispId(168)]
      string GetSet_VFI_DccCardType9_CRCount { [DispId(168)] get; }

      [DispId(169)]
      string GetSet_VFI_DccCardType9_CRAmount { [DispId(169)] get; }

      [DispId(170)]
      string GetSet_VFI_RRN { [DispId(170)] get; [DispId(170)] set; }

      [DispId(171)]
      string GetSet_VFI_XmlRespData { [DispId(171)] get; }

      [DispId(172)]
      string GetSet_VFI_MerchantName { [DispId(172)] get; }

      [DispId(173)]
      string GetSet_VFI_Address1 { [DispId(173)] get; }

      [DispId(174)]
      string GetSet_VFI_Address2 { [DispId(174)] get; }

      [DispId(175)]
      string GetSet_VFI_Address3 { [DispId(175)] get; }

      [DispId(176)]
      string GetSet_VFI_POSApplicationVersion { [DispId(176)] get; }

      [DispId(177)]
      string GetSet_VFI_AddInInfo1 { [DispId(177)] get; [DispId(177)] set; }

      [DispId(178)]
      string GetSet_VFI_AddInInfo2 { [DispId(178)] get; [DispId(178)] set; }

      [DispId(179)]
      string GetSet_VFI_AddInInfo3 { [DispId(179)] get; [DispId(179)] set; }

      [DispId(180)]
      string GetSet_VFI_AddInInfo4 { [DispId(180)] get; [DispId(180)] set; }

      [DispId(181)]
      string GetSet_VFI_AddInInfo5 { [DispId(181)] get; [DispId(181)] set; }

      [DispId(182)]
      string GetSet_VFI_AddInfo1 { [DispId(182)] get; }

      [DispId(183)]
      string GetSet_VFI_AddInfo2 { [DispId(183)] get; }

      [DispId(184)]
      string GetSet_VFI_AddInfo3 { [DispId(184)] get; }

      [DispId(185)]
      string GetSet_VFI_AddInfo4 { [DispId(185)] get; }

      [DispId(186)]
      string GetSet_VFI_AddInfo5 { [DispId(186)] get; }

      [DispId(187)]
      string GetSet_VFI_AddInfo6 { [DispId(187)] get; }

      [DispId(188)]
      string GetSet_VFI_AddInfo7 { [DispId(188)] get; }

      [DispId(189)]
      string GetSet_VFI_AddInfo8 { [DispId(189)] get; }

      [DispId(190)]
      string GetSet_VFI_AddInfo9 { [DispId(190)] get; }

      [DispId(191)]
      string GetSet_VFI_AddInfo10 { [DispId(191)] get; }

      [DispId(192)]
      string GetSet_VFI_ReportType { [DispId(192)] get; [DispId(192)] set; }

      [DispId(193)]
      string GetSet_VFI_BalanceAmount { [DispId(193)] get; }

      [DispId(194)]
      bool VFI_PIE_Purchase();

      [DispId(195)]
      bool VFI_PIE_Refund();

      [DispId(196)]
      bool VFI_PIE_Reissue();

      [DispId(197)]
      bool VFI_PIE_Balance();

      [DispId(198)]
      bool VFI_PIE_Void();

      [DispId(199)]
      bool VFI_PIE_Last5Txn();

      [DispId(200)]
      string VFI_DllVersion();

      [DispId(201)]
      string getCurrentInstruction();

      [DispId(202)]
      bool VFI_Status();

      [DispId(203)]
      string VFI_GetAuth_Json(
        string TerminalID,
        string TransType,
        string Amount,
        string ECRRcptNum,
        string CashAmount,
        string AdditionalInfo);

      [DispId(204)]
      string VFI_VoidTrans_Json(
        string TerminalID,
        string Amount,
        string VoidRcptNum,
        string ECRRcptNum);

      [DispId(205)]
      string VFI_Settle_Json(string TerminalID);

      [DispId(206)]
      string VFI_Report_Json(string TerminalID, string ReportType);

      [DispId(207)]
      string VFI_Status_Json(string TerminalID);

      [DispId(208)]
      string VFI_TxnStatus_Json(string TerminalId, string ECRRcptNum);

      [DispId(209)]
      string VFI_KeyLogOn_Json(string TerminalID);

      [DispId(210)]
      string VFI_GetTidMid_Json(string TerminalID);

      [DispId(211)]
      string VFI_GetTerminalInfo_Json(string TerminalID);

      [DispId(212)]
      string VFI_GetReprint_Json(string TerminalID, string MessNum);

      [DispId(213)]
      string VFI_GetMaskedCardNo_Json(string TerminalID);

      [DispId(214)]
      string VFI_GetAuth_Xml(
        string TerminalID,
        string TransType,
        string Amount,
        string ECRRcptNum,
        string CashAmount,
        string AdditionalInfo);

      [DispId(215)]
      string VFI_Refund_Xml(
        string TransType,
        string TerminalID,
        string Amount,
        string ECRRcptNum,
        string MerchantRefNo,
        string CardBin,
        string CardLast4);

      [DispId(216)]
      string VFI_VoidTrans_Xml(
        string TerminalID,
        string Amount,
        string VoidInvoiceNo,
        string ECRRcptNum);

      [DispId(217)]
      string VFI_Settle_Xml(string TerminalID);

      [DispId(218)]
      string VFI_Report_Xml(string TerminalID, string ReportType);

      [DispId(219)]
      string VFI_SummaryReport_Xml(string TerminalID, string ReportType);

      [DispId(220)]
      string VFI_DetailReport_Xml(string TerminalID, string ReportType);

      [DispId(221)]
      string VFI_TxnStatus_Xml(string TerminalID, string ECRRcptNum);

      [DispId(222)]
      string VFI_GetReprint_Xml(string TerminalId, string MessNum);

      [DispId(223)]
      string VFI_SelectedDCCOffer_Xml(string TerminalId, string RespCode, string DCC_OptIn);

      [DispId(224)]
      string VFI_GetTerminalInfo_Xml(string TerminalId);

      [DispId(225)]
      string getCurrentInstruction_Xml();

      [DispId(226)]
      string VFI_Status_Xml(string TerminalId);

      [DispId(227)]
      string VFI_KeyLogOn_Xml(string TerminalId);

      [DispId(228)]
      string VFI_GetTidMid_Xml();

      [DispId(229)]
      string VFI_GetMaskedCardNo_Xml(string TerminalId);

      [DispId(230)]
      bool VFI_SelectedDCCOffer(string TerminalId, string RespCode, string DCC_OptIn);

      [DispId(231)]
      bool VFI_SelectedDCCOffer();

      [DispId(232)]
      bool VFI_TxnStatus(string TerminalID, string ECRRcptNum);

      [DispId(233)]
      bool VFI_TxnStatus();

      [DispId(234)]
      bool VFI_GetReprint(string TerminalId, string MessNum);

      [DispId(235)]
      bool VFI_GetReprint();

      [DispId(236)]
      bool VFI_GetTerminalInfo();

      [DispId(237)]
      bool VFI_KeyLogOn();

      [DispId(238)]
      bool VFI_GetTidMid();

      [DispId(239)]
      string VFI_Report(string TerminalID, string ReportType);

      [DispId(240)]
      bool VFI_Report();
    }

    [Guid("3ecee5fc-c913-454c-83ab-d2aa91308b32")]
    [InterfaceType(2)]
    [ComVisible(true)]
    public interface __comCMXECR
    {
      [DispId(1)]
      void getPOSCurrentInstruction(string strCurrentInstruction);
    }
  }
}
