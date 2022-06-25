﻿using MessageDbCore.EntityInterfaces;
using System;
using System.Runtime.Serialization;

namespace MessageDbCore.RepoEntity
{
	[DataContract(Name = "VideoMessage")]
	public class VideoMessage : Message, IMultiMediaMessage
	{
		[DataMember(Name = "UniqueGuid")]
		public Guid UniqueGuid { get; set; }

		[DataMember(Name = "FileName")]
		public string FileName { get; set; }

		[DataMember(Name = "Extension")]
		public string MediaFileType { get; set; }

		[DataMember(Name = "FileSize")]
		public double? FileSize { get; set; }

		[DataMember(Name = "Length")]
		public double? Length { get; set; }
	}
}
