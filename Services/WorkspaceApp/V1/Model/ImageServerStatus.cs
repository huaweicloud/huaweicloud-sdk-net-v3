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
    /// 镜像实例的状态: * &#39;CREATING&#39; - 实例创建中 * &#39;ACTIVE&#39; - 实例正常运行 * &#39;BUILDING&#39; - 镜像创建中 * &#39;BUILT&#39; - 镜像任务结束 * &#39;ERROR&#39; - 实例处于异常 * &#39;DELETING&#39; - 实例删除中 * &#39;NULL&#39; - 未设置
    /// </summary>
    /// <value>镜像实例的状态: * &#39;CREATING&#39; - 实例创建中 * &#39;ACTIVE&#39; - 实例正常运行 * &#39;BUILDING&#39; - 镜像创建中 * &#39;BUILT&#39; - 镜像任务结束 * &#39;ERROR&#39; - 实例处于异常 * &#39;DELETING&#39; - 实例删除中 * &#39;NULL&#39; - 未设置</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ImageServerStatus
    {
        /// <summary>
        /// Enum CREATING for value: CREATING
        /// </summary>
        [EnumMember(Value = "CREATING")]
        CREATING = 1,

        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 2,

        /// <summary>
        /// Enum BUILDING for value: BUILDING
        /// </summary>
        [EnumMember(Value = "BUILDING")]
        BUILDING = 3,

        /// <summary>
        /// Enum BUILT for value: BUILT
        /// </summary>
        [EnumMember(Value = "BUILT")]
        BUILT = 4,

        /// <summary>
        /// Enum ERROR for value: ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR = 5,

        /// <summary>
        /// Enum DELETING for value: DELETING
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING = 6,

        /// <summary>
        /// Enum NULL for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        NULL = 7

    }

}
