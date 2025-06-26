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
    /// 应用分类： * &#x60;GAME&#x60; - 游戏 * &#x60;BUSSINESS_INTELLIGENCE&#x60; - 商业智能 * &#x60;SECURE_STORAGE&#x60; - 安全与存储 * &#x60;MULTIMEDIA_AND_CODING&#x60; - 多媒体与编解码 * &#x60;PROJECT_MANAGEMENT&#x60; - 项目管理 * &#x60;PRODUCTIVITY_AND_COLLABORATION&#x60; - 生产力与协作 * &#x60;WEB_ADN_APPLICATION&#x60; - 网页与应用开发 * &#x60;GRAPHIC_DESIGN&#x60; - 图形设计 * &#x60;OTHER&#x60; - 其它
    /// </summary>
    /// <value>应用分类： * &#x60;GAME&#x60; - 游戏 * &#x60;BUSSINESS_INTELLIGENCE&#x60; - 商业智能 * &#x60;SECURE_STORAGE&#x60; - 安全与存储 * &#x60;MULTIMEDIA_AND_CODING&#x60; - 多媒体与编解码 * &#x60;PROJECT_MANAGEMENT&#x60; - 项目管理 * &#x60;PRODUCTIVITY_AND_COLLABORATION&#x60; - 生产力与协作 * &#x60;WEB_ADN_APPLICATION&#x60; - 网页与应用开发 * &#x60;GRAPHIC_DESIGN&#x60; - 图形设计 * &#x60;OTHER&#x60; - 其它</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AppCategoryEnum
    {
        /// <summary>
        /// Enum GAME for value: GAME
        /// </summary>
        [EnumMember(Value = "GAME")]
        GAME = 1,

        /// <summary>
        /// Enum BUSSINESS_INTELLIGENCE for value: BUSSINESS_INTELLIGENCE
        /// </summary>
        [EnumMember(Value = "BUSSINESS_INTELLIGENCE")]
        BUSSINESS_INTELLIGENCE = 2,

        /// <summary>
        /// Enum SECURE_STORAGE for value: SECURE_STORAGE
        /// </summary>
        [EnumMember(Value = "SECURE_STORAGE")]
        SECURE_STORAGE = 3,

        /// <summary>
        /// Enum MULTIMEDIA_AND_CODING for value: MULTIMEDIA_AND_CODING
        /// </summary>
        [EnumMember(Value = "MULTIMEDIA_AND_CODING")]
        MULTIMEDIA_AND_CODING = 4,

        /// <summary>
        /// Enum PROJECT_MANAGEMENT for value: PROJECT_MANAGEMENT
        /// </summary>
        [EnumMember(Value = "PROJECT_MANAGEMENT")]
        PROJECT_MANAGEMENT = 5,

        /// <summary>
        /// Enum PRODUCTIVITY_AND_COLLABORATION for value: PRODUCTIVITY_AND_COLLABORATION
        /// </summary>
        [EnumMember(Value = "PRODUCTIVITY_AND_COLLABORATION")]
        PRODUCTIVITY_AND_COLLABORATION = 6,

        /// <summary>
        /// Enum WEB_ADN_APPLICATION for value: WEB_ADN_APPLICATION
        /// </summary>
        [EnumMember(Value = "WEB_ADN_APPLICATION")]
        WEB_ADN_APPLICATION = 7,

        /// <summary>
        /// Enum GRAPHIC_DESIGN for value: GRAPHIC_DESIGN
        /// </summary>
        [EnumMember(Value = "GRAPHIC_DESIGN")]
        GRAPHIC_DESIGN = 8,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 9

    }

}
