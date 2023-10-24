Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration

Module DataEncrypt
    public command as new mysqlcommand
    public dr as mysqldatareader
    private tripledes as new TripleDESCryptoServiceProvider


    ' public function encryptdata(byval plaintext as string) as String

    '    Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
    '        Dim ms As New System.IO.MemoryStream
    '        Dim encStream As New CryptoStream(ms, tripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)


    '        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
    '        encStream.FlushFinalBlock()

    '        Return Convert.ToBase64String(ms.ToArray)


    'End Function

    'Public Function DecryptData(ByVal encryptedtext As String) As String



    '    Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)
    '        Dim ms As New System.IO.MemoryStream
    '        Dim decStream As New CryptoStream(ms, tripleDes.CreateDecryptor(),
    '                                           System.Security.Cryptography.CryptoStreamMode.Write)

    '        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
    '        decStream.FlushFinalBlock()



    '        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)

    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
         &H65, &H64, &H76, &H65, &H64, &H65,
         &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function


    Public Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        cipherText = cipherText.Trim()
        Dim data As Int32 = cipherText.Length Mod 4
        If data > 0 Then
            cipherText += New String("=", 4 - data)
        End If

        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)





        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText

    End Function



    '  End Function





















End Module
