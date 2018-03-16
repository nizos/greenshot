﻿/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2018 Thomas Braun, Jens Klingen, Robin Krom
 * 
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Collections.Generic;
using System.ComponentModel;
using Dapplo.Ini;
using GreenshotPlugin.Core.Enums;

namespace Greenshot.Addon.Lutim {
	/// <summary>
	/// Description of LutimConfiguration.
	/// </summary>
	[IniSection("Lutim")]
    [Description("Greenshot Lutim Plugin configuration")]
	public interface ILutimConfiguration : IIniSection
	{
		[Description("Url to Lutim system.")]
		[DefaultValue("https://lut.im/")]
		string LutimUrl { get; set; }

		[Description("What file type to use for uploading")]
	    [DefaultValue(OutputFormats.png)]
		OutputFormats UploadFormat { get; set; }

	    [Description("JPEG file save quality in %.")]
		[DefaultValue(80)]
		int UploadJpegQuality { get; set; }

	    [Description("Reduce color amount of the uploaded image to 256")]
		[DefaultValue(false)]
		bool UploadReduceColors { get; set; }

	    [Description("Copy the link, which one is controlled by the UsePageLink, on the clipboard")]
		[DefaultValue(true)]
		bool CopyLinkToClipboard { get; set; }
		
		[Description("Lutim upload history (LutimUploadHistory.Short=CreatedAt;DelAtView;Ext;Filename;Limit;RealShort;Token;LutimBaseUri;Thumb(base64))")]
		IDictionary<string, string> LutimUploadHistory { get; set; }

		[Description("Filename for the Lutim upload")]
		[DefaultValue("${capturetime:d\"yyyyMMdd-HHmm\"}")]
		string FilenamePattern { get; set; }

	    [IniPropertyBehavior(Read = false, Write = false)]
        IDictionary<string, LutimInfo> RuntimeLutimHistory { get; set; }
	}
}
