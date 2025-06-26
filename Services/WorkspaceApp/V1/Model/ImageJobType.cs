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
    /// job类型。 * &#x60;CREATE_SERVER&#x60; - 创建镜像实例 * &#x60;CREATE_SERVER_IMAGE&#x60; - 构建镜像 * &#x60;DELETE_SERVER&#x60; - 删除镜像实例
    /// </summary>
    /// <value>job类型。 * &#x60;CREATE_SERVER&#x60; - 创建镜像实例 * &#x60;CREATE_SERVER_IMAGE&#x60; - 构建镜像 * &#x60;DELETE_SERVER&#x60; - 删除镜像实例</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ImageJobType
    {
        /// <summary>
        /// Enum CREATE_SERVER for value: CREATE_SERVER
        /// </summary>
        [EnumMember(Value = "CREATE_SERVER")]
        CREATE_SERVER = 1,

        /// <summary>
        /// Enum CREATE_SERVER_IMAGE for value: CREATE_SERVER_IMAGE
        /// </summary>
        [EnumMember(Value = "CREATE_SERVER_IMAGE")]
        CREATE_SERVER_IMAGE = 2,

        /// <summary>
        /// Enum DELETE_SERVER for value: DELETE_SERVER
        /// </summary>
        [EnumMember(Value = "DELETE_SERVER")]
        DELETE_SERVER = 3

    }

}
