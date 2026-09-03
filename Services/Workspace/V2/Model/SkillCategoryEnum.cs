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
    /// 技能分类枚举。
    /// </summary>
    /// <value>技能分类枚举。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SkillCategoryEnum
    {
        /// <summary>
        /// Enum SYSTEM_CORE for value: SYSTEM_CORE
        /// </summary>
        [EnumMember(Value = "SYSTEM_CORE")]
        SYSTEM_CORE = 1,

        /// <summary>
        /// Enum AI_COGNITIVE for value: AI_COGNITIVE
        /// </summary>
        [EnumMember(Value = "AI_COGNITIVE")]
        AI_COGNITIVE = 2,

        /// <summary>
        /// Enum WEB_SEARCH for value: WEB_SEARCH
        /// </summary>
        [EnumMember(Value = "WEB_SEARCH")]
        WEB_SEARCH = 3,

        /// <summary>
        /// Enum BROWSER_AUTOMATION for value: BROWSER_AUTOMATION
        /// </summary>
        [EnumMember(Value = "BROWSER_AUTOMATION")]
        BROWSER_AUTOMATION = 4,

        /// <summary>
        /// Enum DEV_CODE for value: DEV_CODE
        /// </summary>
        [EnumMember(Value = "DEV_CODE")]
        DEV_CODE = 5,

        /// <summary>
        /// Enum DOC_KNOWLEDGE for value: DOC_KNOWLEDGE
        /// </summary>
        [EnumMember(Value = "DOC_KNOWLEDGE")]
        DOC_KNOWLEDGE = 6,

        /// <summary>
        /// Enum OFFICE_COLLAB for value: OFFICE_COLLAB
        /// </summary>
        [EnumMember(Value = "OFFICE_COLLAB")]
        OFFICE_COLLAB = 7,

        /// <summary>
        /// Enum WORKFLOW_AUTOMATION for value: WORKFLOW_AUTOMATION
        /// </summary>
        [EnumMember(Value = "WORKFLOW_AUTOMATION")]
        WORKFLOW_AUTOMATION = 8,

        /// <summary>
        /// Enum MULTIMEDIA_CREATIVE for value: MULTIMEDIA_CREATIVE
        /// </summary>
        [EnumMember(Value = "MULTIMEDIA_CREATIVE")]
        MULTIMEDIA_CREATIVE = 9,

        /// <summary>
        /// Enum SYSTEM_TOOLS for value: SYSTEM_TOOLS
        /// </summary>
        [EnumMember(Value = "SYSTEM_TOOLS")]
        SYSTEM_TOOLS = 10

    }

}
