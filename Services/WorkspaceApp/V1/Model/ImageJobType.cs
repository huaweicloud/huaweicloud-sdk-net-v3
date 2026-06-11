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
        DELETE_SERVER = 3,

        /// <summary>
        /// Enum BUILD_IMAGE for value: BUILD_IMAGE
        /// </summary>
        [EnumMember(Value = "BUILD_IMAGE")]
        BUILD_IMAGE = 4,

        /// <summary>
        /// Enum GENERATE_IMAGE for value: GENERATE_IMAGE
        /// </summary>
        [EnumMember(Value = "GENERATE_IMAGE")]
        GENERATE_IMAGE = 5,

        /// <summary>
        /// Enum DELETE_IMAGE_BUILD_SERVER for value: DELETE_IMAGE_BUILD_SERVER
        /// </summary>
        [EnumMember(Value = "DELETE_IMAGE_BUILD_SERVER")]
        DELETE_IMAGE_BUILD_SERVER = 6,

        /// <summary>
        /// Enum DELETE_IMAGE for value: DELETE_IMAGE
        /// </summary>
        [EnumMember(Value = "DELETE_IMAGE")]
        DELETE_IMAGE = 7

    }

}
