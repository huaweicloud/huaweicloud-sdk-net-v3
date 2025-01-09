using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 安装方式：   * &#x60;QUIET_INSTALL&#x60; - 静默安装。     安装命令(静默安装命令)，例: ${FILE_PATH} /S。   * &#x60;UNZIP_INSTALL&#x60; - 解压安装。     例: unzip ${FILE_PATH}。   * &#x60;GUI_INSTALL&#x60; - 用户通过GUI界面安装。 install_type为QUIET_INSTALL、UNZIP_INSTALL时install_command非空。 预定义变量将采用以下值: ${FILE_PATH}: 应用安装包在桌面本地的存储路径。
    /// </summary>
    /// <value>安装方式：   * &#x60;QUIET_INSTALL&#x60; - 静默安装。     安装命令(静默安装命令)，例: ${FILE_PATH} /S。   * &#x60;UNZIP_INSTALL&#x60; - 解压安装。     例: unzip ${FILE_PATH}。   * &#x60;GUI_INSTALL&#x60; - 用户通过GUI界面安装。 install_type为QUIET_INSTALL、UNZIP_INSTALL时install_command非空。 预定义变量将采用以下值: ${FILE_PATH}: 应用安装包在桌面本地的存储路径。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InstallType
    {
        /// <summary>
        /// Enum QUIET_INSTALL for value: QUIET_INSTALL
        /// </summary>
        [EnumMember(Value = "QUIET_INSTALL")]
        QUIET_INSTALL = 1,

        /// <summary>
        /// Enum UNZIP_INSTALL for value: UNZIP_INSTALL
        /// </summary>
        [EnumMember(Value = "UNZIP_INSTALL")]
        UNZIP_INSTALL = 2,

        /// <summary>
        /// Enum GUI_INSTALL for value: GUI_INSTALL
        /// </summary>
        [EnumMember(Value = "GUI_INSTALL")]
        GUI_INSTALL = 3

    }

}
