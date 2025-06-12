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
    /// 任务状态。 * CREATING: 创建中 * SYSTEM_AUDITING: 系统审核中 * AUDITING: 人工审核中 * WAITING_SPLIT: 等待切割 * SPLITTING: 切割中 * SPLIT_FAILED: 切割失败 * ANNOTATING: 标注中 * WAITING: 等待训练 * PROCESSING: 任务训练中 * RESULT_REVIEW: 审核结果 * AUDIT_FAILED: 审核失败,等待用户重传数据 * UPLOADING: 上传中 * FAILED: 失败 * SUCCEED: 成功
    /// </summary>
    /// <value>任务状态。 * CREATING: 创建中 * SYSTEM_AUDITING: 系统审核中 * AUDITING: 人工审核中 * WAITING_SPLIT: 等待切割 * SPLITTING: 切割中 * SPLIT_FAILED: 切割失败 * ANNOTATING: 标注中 * WAITING: 等待训练 * PROCESSING: 任务训练中 * RESULT_REVIEW: 审核结果 * AUDIT_FAILED: 审核失败,等待用户重传数据 * UPLOADING: 上传中 * FAILED: 失败 * SUCCEED: 成功</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum JobState
    {
        /// <summary>
        /// Enum CREATING for value: CREATING
        /// </summary>
        [EnumMember(Value = "CREATING")]
        CREATING = 1,

        /// <summary>
        /// Enum SYSTEM_AUDITING for value: SYSTEM_AUDITING
        /// </summary>
        [EnumMember(Value = "SYSTEM_AUDITING")]
        SYSTEM_AUDITING = 2,

        /// <summary>
        /// Enum AUDITING for value: AUDITING
        /// </summary>
        [EnumMember(Value = "AUDITING")]
        AUDITING = 3,

        /// <summary>
        /// Enum WAITING_SPLIT for value: WAITING_SPLIT
        /// </summary>
        [EnumMember(Value = "WAITING_SPLIT")]
        WAITING_SPLIT = 4,

        /// <summary>
        /// Enum SPLITTING for value: SPLITTING
        /// </summary>
        [EnumMember(Value = "SPLITTING")]
        SPLITTING = 5,

        /// <summary>
        /// Enum SPLIT_FAILED for value: SPLIT_FAILED
        /// </summary>
        [EnumMember(Value = "SPLIT_FAILED")]
        SPLIT_FAILED = 6,

        /// <summary>
        /// Enum ANNOTATING for value: ANNOTATING
        /// </summary>
        [EnumMember(Value = "ANNOTATING")]
        ANNOTATING = 7,

        /// <summary>
        /// Enum WAITING for value: WAITING
        /// </summary>
        [EnumMember(Value = "WAITING")]
        WAITING = 8,

        /// <summary>
        /// Enum PROCESSING for value: PROCESSING
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING = 9,

        /// <summary>
        /// Enum RESULT_REVIEW for value: RESULT_REVIEW
        /// </summary>
        [EnumMember(Value = "RESULT_REVIEW")]
        RESULT_REVIEW = 10,

        /// <summary>
        /// Enum AUDIT_FAILED for value: AUDIT_FAILED
        /// </summary>
        [EnumMember(Value = "AUDIT_FAILED")]
        AUDIT_FAILED = 11,

        /// <summary>
        /// Enum USER_RESULT_REVIEW for value: USER_RESULT_REVIEW
        /// </summary>
        [EnumMember(Value = "USER_RESULT_REVIEW")]
        USER_RESULT_REVIEW = 12,

        /// <summary>
        /// Enum USER_REVIEW_REJECT for value: USER_REVIEW_REJECT
        /// </summary>
        [EnumMember(Value = "USER_REVIEW_REJECT")]
        USER_REVIEW_REJECT = 13,

        /// <summary>
        /// Enum UPLOADING for value: UPLOADING
        /// </summary>
        [EnumMember(Value = "UPLOADING")]
        UPLOADING = 14,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 15,

        /// <summary>
        /// Enum SUCCEED for value: SUCCEED
        /// </summary>
        [EnumMember(Value = "SUCCEED")]
        SUCCEED = 16

    }

}
