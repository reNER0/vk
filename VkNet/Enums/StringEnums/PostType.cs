using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace VkNet.Enums.SafetyEnums;

/// <summary>
/// Тип записи post, copy, reply, postpone, suggest
/// </summary>
[StringEnum]
[JsonConverter(typeof(StringEnumConverter), typeof(SnakeCaseNamingStrategy))]
public enum PostType
{
	/// <summary>
	/// Запись на стене (по умолчанию);
	/// v5.6+ - репосты имею тип "post"
	/// </summary>
	Post,

	/// <summary>
	/// Репост до версии 5.6 (сейчас не описано)
	/// </summary>
	Copy,

	/// <summary>
	/// Ответ на запись с закрытыми комментариями (м.б. еще что-то)
	/// </summary>
	Reply,

	/// <summary>
	/// Закрепленная запись
	/// </summary>
	Postpone,

	/// <summary>
	/// Предложенная запись
	/// </summary>
	Suggest
}