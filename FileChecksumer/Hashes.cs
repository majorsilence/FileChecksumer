/*
* Copyright 2010 (C) Peter Gill <peter@majorsilence.com>
*
* This file is part of MajorSilence FileChecksumer
*
* MajorSilence FileChecksumer is free software; you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation; either version 3 of the License, or
* (at your option) any later version.
*
* MajorSilence FileChecksumer is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/



using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace FileChecksumer
{
    class Hashes
    {
        // See http://www.marxio-tools.net/en/fcv-gal/index.php?start=6

        public string GetMD5Hash(string fileName)
        {
            string value = "";
            using (MD5 _md5 = new MD5CryptoServiceProvider())
            {
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    byte[] retVal = _md5.ComputeHash(file);
                    value = BitConverter.ToString(retVal).Replace("-", ""); // hex string
                }
            }


            return value;
        }


        public string GetSHA1Hash(string fileName)
        {
            string value = "";
            using (SHA1 _sha1 = new SHA1CryptoServiceProvider())
            {
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    byte[] retVal = _sha1.ComputeHash(file);
                    value = BitConverter.ToString(retVal).Replace("-", ""); // hex string
                }
            }


            return value;
        }

        public string GetSHA512Hash(string fileName)
        {
            string value = "";
            using (SHA512 _sha512 = new SHA512Managed())
            {
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    byte[] retVal = _sha512.ComputeHash(file);
                    value = BitConverter.ToString(retVal).Replace("-", ""); // hex string
                }
            }


            return value;
        }
    }
}
