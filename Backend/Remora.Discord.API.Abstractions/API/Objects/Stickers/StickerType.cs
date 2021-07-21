//
//  StickerType.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

namespace Remora.Discord.API.Abstractions.Objects
{
    /// <summary>
    /// Enumerates various types of stickers.
    /// </summary>
    public enum StickerType
    {
        /// <summary>
        /// An official sticker in a pack, part of Nitro or in a removed purchasable pack.
        /// </summary>
        Standard = 1,

        /// <summary>
        /// A sticker uploaded to a boosted guild for the guild's members.
        /// </summary>
        Guild = 2
    }
}