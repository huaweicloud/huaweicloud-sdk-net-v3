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
    /// 镜像类型： * &#x60;gold&#x60; - 云市场镜像 * &#x60;public&#x60; - 公共镜像 * &#x60;private&#x60; - 私有镜像 * &#x60;shared&#x60; - 共享镜像 * &#x60;other&#x60; - 其他
    /// </summary>
    /// <value>镜像类型： * &#x60;gold&#x60; - 云市场镜像 * &#x60;public&#x60; - 公共镜像 * &#x60;private&#x60; - 私有镜像 * &#x60;shared&#x60; - 共享镜像 * &#x60;other&#x60; - 其他</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ImageTypeEnum
    {
        /// <summary>
        /// Enum GOLD for value: gold
        /// </summary>
        [EnumMember(Value = "gold")]
        GOLD = 1,

        /// <summary>
        /// Enum PUBLIC for value: public
        /// </summary>
        [EnumMember(Value = "public")]
        PUBLIC = 2,

        /// <summary>
        /// Enum PRIVATE for value: private
        /// </summary>
        [EnumMember(Value = "private")]
        PRIVATE = 3,

        /// <summary>
        /// Enum SHARED for value: shared
        /// </summary>
        [EnumMember(Value = "shared")]
        SHARED = 4,

        /// <summary>
        /// Enum OTHER for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        OTHER = 5

    }

}
