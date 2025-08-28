using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 知识库类型 * QUESTION_ANSWER：问答 * DOCUMENT：文档
    /// </summary>
    /// <value>知识库类型 * QUESTION_ANSWER：问答 * DOCUMENT：文档</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum KnowledgeTypeEnum
    {
        /// <summary>
        /// Enum QUESTION_ANSWER for value: QUESTION_ANSWER
        /// </summary>
        [EnumMember(Value = "QUESTION_ANSWER")]
        QUESTION_ANSWER = 1,

        /// <summary>
        /// Enum DOCUMENT for value: DOCUMENT
        /// </summary>
        [EnumMember(Value = "DOCUMENT")]
        DOCUMENT = 2

    }

}
