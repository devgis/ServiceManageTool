﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace LNS.ServicesManageTool
{
    public class SystemDBConfig
    {
        #region"基本操作函数"
        /// <summary>
        /// 得到程序工作目录
        /// </summary>
        /// <returns></returns>
        private static string GetWorkDirectory()
        {
            string sPath = Environment.GetEnvironmentVariable(PublicDim.LNSEnvironmentVariable);
            return sPath;
            //try
            //{
            //    return Path.GetDirectoryName(typeof(SystemDBConfig).Assembly.Location);
            //}
            //catch
            //{
            //    return System.Windows.Forms.Application.StartupPath;
            //}
        }
        /// <summary>
        /// 判断字符串是否为空串
        /// </summary>
        /// <param name="szString">目标字符串</param>
        /// <returns>true:为空串;false:非空串</returns>
        private static bool IsEmptyString(string szString)
        {
            if (szString == null)
                return true;
            if (szString.Trim() == string.Empty)
                return true;
            return false;
        }
        /// <summary>
        /// 创建一个制定根节点名的XML文件
        /// </summary>
        /// <param name="szFileName">XML文件</param>
        /// <param name="szRootName">根节点名</param>
        /// <returns>bool</returns>
        private static bool CreateXmlFile(string szFileName, string szRootName)
        {
            if (szFileName == null || szFileName.Trim() == "")
                return false;
            if (szRootName == null || szRootName.Trim() == "")
                return false;

            XmlDocument clsXmlDoc = new XmlDocument();
            clsXmlDoc.AppendChild(clsXmlDoc.CreateXmlDeclaration("1.0", "GBK", null));
            clsXmlDoc.AppendChild(clsXmlDoc.CreateNode(XmlNodeType.Element, szRootName, ""));
            try
            {
                clsXmlDoc.Save(szFileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 从XML文件获取对应的XML文档对象
        /// </summary>
        /// <param name="szXmlFile">XML文件</param>
        /// <returns>XML文档对象</returns>
        private static XmlDocument GetXmlDocument(string szXmlFile)
        {
            if (IsEmptyString(szXmlFile))
                return null;
            if (!File.Exists(szXmlFile))
                return null;
            XmlDocument clsXmlDoc = new XmlDocument();
            try
            {
                clsXmlDoc.Load(szXmlFile);
            }
            catch
            {
                return null;
            }
            return clsXmlDoc;
        }

        /// <summary>
        /// 将XML文档对象保存为XML文件
        /// </summary>
        /// <param name="clsXmlDoc">XML文档对象</param>
        /// <param name="szXmlFile">XML文件</param>
        /// <returns>bool:保存结果</returns>
        private static bool SaveXmlDocument(XmlDocument clsXmlDoc, string szXmlFile)
        {
            if (clsXmlDoc == null)
                return false;
            if (IsEmptyString(szXmlFile))
                return false;
            try
            {
                if (File.Exists(szXmlFile))
                    File.Delete(szXmlFile);
            }
            catch
            {
                return false;
            }
            try
            {
                clsXmlDoc.Save(szXmlFile);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取XPath指向的单一XML节点
        /// </summary>
        /// <param name="clsRootNode">XPath所在的根节点</param>
        /// <param name="szXPath">XPath表达式</param>
        /// <returns>XmlNode</returns>
        private static XmlNode SelectXmlNode(XmlNode clsRootNode, string szXPath)
        {
            if (clsRootNode == null || IsEmptyString(szXPath))
                return null;
            try
            {
                return clsRootNode.SelectSingleNode(szXPath);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取XPath指向的XML节点集
        /// </summary>
        /// <param name="clsRootNode">XPath所在的根节点</param>
        /// <param name="szXPath">XPath表达式</param>
        /// <returns>XmlNodeList</returns>
        private static XmlNodeList SelectXmlNodes(XmlNode clsRootNode, string szXPath)
        {
            if (clsRootNode == null || IsEmptyString(szXPath))
                return null;
            try
            {
                return clsRootNode.SelectNodes(szXPath);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 创建一个XmlNode并添加到文档
        /// </summary>
        /// <param name="clsParentNode">父节点</param>
        /// <param name="szNodeName">结点名称</param>
        /// <returns>XmlNode</returns>
        private static XmlNode CreateXmlNode(XmlNode clsParentNode, string szNodeName)
        {
            try
            {
                XmlDocument clsXmlDoc = null;
                if (clsParentNode.GetType() != typeof(XmlDocument))
                    clsXmlDoc = clsParentNode.OwnerDocument;
                else
                    clsXmlDoc = clsParentNode as XmlDocument;
                XmlNode clsXmlNode = clsXmlDoc.CreateNode(XmlNodeType.Element, szNodeName, string.Empty);
                if (clsParentNode.GetType() == typeof(XmlDocument))
                {
                    clsXmlDoc.LastChild.AppendChild(clsXmlNode);
                }
                else
                {
                    clsParentNode.AppendChild(clsXmlNode);
                }
                return clsXmlNode;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 设置指定节点中指定属性的值
        /// </summary>
        /// <param name="parentNode">XML节点</param>
        /// <param name="szAttrName">属性名</param>
        /// <param name="szAttrValue">属性值</param>
        /// <returns>bool</returns>
        private static bool SetXmlAttr(XmlNode clsXmlNode, string szAttrName, string szAttrValue)
        {
            if (clsXmlNode == null)
                return false;
            if (IsEmptyString(szAttrName))
                return false;
            if (IsEmptyString(szAttrValue))
                szAttrValue = string.Empty;
            XmlAttribute clsAttrNode = clsXmlNode.Attributes.GetNamedItem(szAttrName) as XmlAttribute;
            if (clsAttrNode == null)
            {
                XmlDocument clsXmlDoc = clsXmlNode.OwnerDocument;
                if (clsXmlDoc == null)
                    return false;
                clsAttrNode = clsXmlDoc.CreateAttribute(szAttrName);
                clsXmlNode.Attributes.Append(clsAttrNode);
            }
            clsAttrNode.Value = szAttrValue;
            return true;
        }
        #endregion

        #region"配置文件的读取和写入"
        private static string CONFIG_FILE = "DBConfig.xml";
        /// <summary>
        ///  读取指定的配置文件中指定Key的值
        /// </summary>
        /// <param name="szKeyName">读取的Key名称</param>
        /// <param name="szDefaultValue">指定的Key不存在时,返回的值</param>
        /// <returns>Key值</returns>
        public static int GetConfigData(string szKeyName, int nDefaultValue)
        {
            string szValue = GetConfigData(szKeyName, nDefaultValue.ToString());
            try
            {
                return int.Parse(szValue);
            }
            catch
            {
                return nDefaultValue;
            }
        }

        /// <summary>
        ///  读取指定的配置文件中指定Key的值
        /// </summary>
        /// <param name="szKeyName">读取的Key名称</param>
        /// <param name="szDefaultValue">指定的Key不存在时,返回的值</param>
        /// <returns>Key值</returns>
        public static float GetConfigData(string szKeyName, float fDefaultValue)
        {
            string szValue = GetConfigData(szKeyName, fDefaultValue.ToString());
            try
            {
                return float.Parse(szValue);
            }
            catch
            {
                return fDefaultValue;
            }
        }

        /// <summary>
        ///  读取指定的配置文件中指定Key的值
        /// </summary>
        /// <param name="szKeyName">读取的Key名称</param>
        /// <param name="szDefaultValue">指定的Key不存在时,返回的值</param>
        /// <returns>Key值</returns>
        public static bool GetConfigData(string szKeyName, bool bDefaultValue)
        {
            string szValue = GetConfigData(szKeyName, bDefaultValue.ToString());
            try
            {
                return bool.Parse(szValue);
            }
            catch
            {
                return bDefaultValue;
            }
        }

        /// <summary>
        ///  读取指定的配置文件中指定Key的值
        /// </summary>
        /// <param name="szKeyName">读取的Key名称</param>
        /// <param name="szDefaultValue">指定的Key不存在时,返回的值</param>
        /// <returns>Key值</returns>
        public static string GetConfigData(string szKeyName, string szDefaultValue)
        {
            string szConfigFile = string.Format("{0}\\{1}", GetWorkDirectory(), CONFIG_FILE);
            if (!File.Exists(szConfigFile))
            {
                throw new Exception("配置文件不存在！");
            }

            XmlDocument clsXmlDoc = GetXmlDocument(szConfigFile);
            if (clsXmlDoc == null)
                return szDefaultValue;

            foreach (XmlNode xnode in clsXmlDoc.ChildNodes[1].ChildNodes)
            {
                if (szKeyName.Equals(xnode.Name))
                {
                    return xnode.Attributes["value"].Value;
                }
            }

            //string szXPath = string.Format(".//key[@value='{0}']", szKeyName);
            //XmlNode clsXmlNode = SelectXmlNode(clsXmlDoc, szXPath);
            //if (clsXmlNode == null)
            //{
            //    return szDefaultValue;
            //}

            //XmlNode clsValueAttr = clsXmlNode.Attributes.GetNamedItem("value");
            //if (clsValueAttr == null)
            return szDefaultValue;
        }

        /// <summary>
        ///  保存指定Key的值到指定的配置文件中
        /// </summary>
        /// <param name="szKeyName">要被修改值的Key名称</param>
        /// <param name="szValue">新修改的值</param>
        public static bool WriteConfigData(string szKeyName, string szValue)
        {
            string szConfigFile = string.Format("{0}\\{1}", GetWorkDirectory(), CONFIG_FILE);
            if (!File.Exists(szConfigFile))
            {
                if (!CreateXmlFile(szConfigFile, "configuration"))
                    return false;
            }
            XmlDocument clsXmlDoc = GetXmlDocument(szConfigFile);

            bool bfind = false;
            foreach (XmlNode xnode in clsXmlDoc.ChildNodes[1].ChildNodes)
            {
                if (szKeyName.Equals(xnode.Name))
                {
                    xnode.Attributes["value"].Value = szValue;
                    bfind = true;
                }
            }

            if (!bfind)
            {
                XmlNode xnewnode = clsXmlDoc.CreateElement(szKeyName);
                //xnode.Name = szKeyName;
                XmlAttribute XmlArtNode = clsXmlDoc.CreateAttribute("value");
                xnewnode.Attributes.Append(XmlArtNode);
                xnewnode.Attributes["value"].Value = szValue;
                clsXmlDoc.ChildNodes[1].AppendChild(xnewnode);
            }
            //string szXPath = string.Format(".//key[@name='{0}']", szKeyName);
            //XmlNode clsXmlNode = SelectXmlNode(clsXmlDoc, szXPath);
            //if (clsXmlNode == null)
            //{
            //    clsXmlNode = CreateXmlNode(clsXmlDoc, "key");
            //}
            //if (!SetXmlAttr(clsXmlNode, "name", szKeyName))
            //    return false;
            //if (!SetXmlAttr(clsXmlNode, "value", szValue))
            //    return false;
            //
            return SaveXmlDocument(clsXmlDoc, szConfigFile);
        }
        #endregion
    }
}
