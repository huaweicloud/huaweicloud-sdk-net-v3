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
    /// 加密类型。 - KEEP：保持原有加密状态 - UNENCRYPTED：不加密 - ENCRYPTED：加密（需同步上传kms_id）
    /// </summary>
    /// <value>加密类型。 - KEEP：保持原有加密状态 - UNENCRYPTED：不加密 - ENCRYPTED：加密（需同步上传kms_id）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EncryptType
    {
        /// <summary>
        /// Enum KEEP for value: KEEP
        /// </summary>
        [EnumMember(Value = "KEEP")]
        KEEP = 1,

        /// <summary>
        /// Enum UNENCRYPTED for value: UNENCRYPTED
        /// </summary>
        [EnumMember(Value = "UNENCRYPTED")]
        UNENCRYPTED = 2,

        /// <summary>
        /// Enum ENCRYPTED for value: ENCRYPTED
        /// </summary>
        [EnumMember(Value = "ENCRYPTED")]
        ENCRYPTED = 3

    }

}
