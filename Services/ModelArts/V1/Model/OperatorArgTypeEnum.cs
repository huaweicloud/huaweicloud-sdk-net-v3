using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 算子参数的类型枚举，表示参数值的数据类型，枚举值： - INT - FLOAT - STRING - ENUM - LIST - BOOLEAN - LARGE_MODEL - OBS - LABEL_FILTER - DATASET - DYNAMIC_INPUT_LIST - PROMPT - OUTPUT_TASK_CATEGORY
    /// </summary>
    /// <value>算子参数的类型枚举，表示参数值的数据类型，枚举值： - INT - FLOAT - STRING - ENUM - LIST - BOOLEAN - LARGE_MODEL - OBS - LABEL_FILTER - DATASET - DYNAMIC_INPUT_LIST - PROMPT - OUTPUT_TASK_CATEGORY</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OperatorArgTypeEnum
    {
        /// <summary>
        /// Enum INT for value: INT
        /// </summary>
        [EnumMember(Value = "INT")]
        INT = 1,

        /// <summary>
        /// Enum FLOAT for value: FLOAT
        /// </summary>
        [EnumMember(Value = "FLOAT")]
        FLOAT = 2,

        /// <summary>
        /// Enum STRING for value: STRING
        /// </summary>
        [EnumMember(Value = "STRING")]
        STRING = 3,

        /// <summary>
        /// Enum ENUM for value: ENUM
        /// </summary>
        [EnumMember(Value = "ENUM")]
        ENUM = 4,

        /// <summary>
        /// Enum LIST for value: LIST
        /// </summary>
        [EnumMember(Value = "LIST")]
        LIST = 5,

        /// <summary>
        /// Enum BOOLEAN for value: BOOLEAN
        /// </summary>
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN = 6,

        /// <summary>
        /// Enum LARGE_MODEL for value: LARGE_MODEL
        /// </summary>
        [EnumMember(Value = "LARGE_MODEL")]
        LARGE_MODEL = 7,

        /// <summary>
        /// Enum OBS for value: OBS
        /// </summary>
        [EnumMember(Value = "OBS")]
        OBS = 8,

        /// <summary>
        /// Enum LABEL_FILTER for value: LABEL_FILTER
        /// </summary>
        [EnumMember(Value = "LABEL_FILTER")]
        LABEL_FILTER = 9,

        /// <summary>
        /// Enum DATASET for value: DATASET
        /// </summary>
        [EnumMember(Value = "DATASET")]
        DATASET = 10,

        /// <summary>
        /// Enum DYNAMIC_INPUT_LIST for value: DYNAMIC_INPUT_LIST
        /// </summary>
        [EnumMember(Value = "DYNAMIC_INPUT_LIST")]
        DYNAMIC_INPUT_LIST = 11,

        /// <summary>
        /// Enum PROMPT for value: PROMPT
        /// </summary>
        [EnumMember(Value = "PROMPT")]
        PROMPT = 12,

        /// <summary>
        /// Enum OUTPUT_TASK_CATEGORY for value: OUTPUT_TASK_CATEGORY
        /// </summary>
        [EnumMember(Value = "OUTPUT_TASK_CATEGORY")]
        OUTPUT_TASK_CATEGORY = 13

    }

}
