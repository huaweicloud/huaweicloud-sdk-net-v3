using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 用户访问APS的应用时，对应NAS存储目录在APS上的挂载策略。 * &#x60;USER&#x60; - 仅挂载个人目录。 * &#x60;SHARE&#x60; - 仅挂载共享目录。 * &#x60;ANY&#x60; - 挂载目录不做限制(个人和共享NAS存储目录都会自动挂载)。
    /// </summary>
    /// <value>用户访问APS的应用时，对应NAS存储目录在APS上的挂载策略。 * &#x60;USER&#x60; - 仅挂载个人目录。 * &#x60;SHARE&#x60; - 仅挂载共享目录。 * &#x60;ANY&#x60; - 挂载目录不做限制(个人和共享NAS存储目录都会自动挂载)。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StorageFolderMountType
    {
        /// <summary>
        /// Enum USER for value: USER
        /// </summary>
        [EnumMember(Value = "USER")]
        USER = 1,

        /// <summary>
        /// Enum SHARE for value: SHARE
        /// </summary>
        [EnumMember(Value = "SHARE")]
        SHARE = 2,

        /// <summary>
        /// Enum ANY for value: ANY
        /// </summary>
        [EnumMember(Value = "ANY")]
        ANY = 3

    }

}
