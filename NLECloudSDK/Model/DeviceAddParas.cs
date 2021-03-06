﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/************************************************************
*CLR版本:4.0.30319.42000
*命名空间:NLECloudSDK.Model
*文件名:DeviceAddParas
*创建时间:2018/5/4 10:48:28
==============================================================
*修改人:
*修改时间:2018/5/4 10:48:28
*修改描述:

************************************************************/
namespace NLECloudSDK.Model
{
    public class DeviceAddParas
    {
        /// <summary>
        /// 通讯协议（1:TCP 2:MQTT 3:HTTP） 
        /// </summary>
        public byte Protocol { get; set; }

        /// <summary>
        /// 数据上报状态，true | false（可选，默认为ture） 
        /// </summary>
        public Boolean IsTrans { get; set; }

        /// <summary>
        /// 项目ID（一个数字）或标识码（一个32位字符串）
        /// </summary>
        public string ProjectIdOrTag { get; set; }

        /// <summary>
        /// 设备名称（中英文、数字的6到15个字）
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 设备标识（英文、数字或其组合6到30个字符） 
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 设备座标（可选，格式为经度值, 纬度值）
        /// </summary>
        public string Coordinate { get; set; }

        /// <summary>
        /// 设备头像（可选）
        /// </summary>
        public string DeviceImg { get; set; }

        /// <summary>
        /// 数据保密性，true | false（可选，默认为ture） 
        /// </summary>
        public Boolean IsShare { get; set; }
    }
}
