# Domain_Checker_for_Outlook
2022
Outlook Add in that checks the recipients of emails you sent and alert you if you are sending email to multiple email domains. 
This is useful for instance if you are an account management role and accidentally adding the wrong email is a big issue
It will ignore your own domain as you most likely copy people from your own domain on a regular basis. You have the option to have the add in remember your selection and send (so as not to ask again in the future)

Tested on Outlook / Office 365 installed on Windows 10 when integrating MAPI emails

To install download Domain Checker Installer.zip and unzip on your computer. Then open folder and run setup. If properly installed, outlook will show an "Add-Ins" tab in the ribbon. 
If Outlook complains of disabled Add-in (sometimes happens first time)
1. Dismiss Message
2. Click File > Options > Add-Ins
3. At bottom of screen, you will see Manage: COM Add-Ins. Toggle to Disabled Add-ins. Click Go. Select Domain Checker and click Enable and then Close
4. At bottom of screen, you will see Manage: Disabled Add-Ins. Toggle to COM Add-ins. Click Go. Select Domain Checker and click checkbox so it is checked. The click ok

![image](https://user-images.githubusercontent.com/24392647/201500541-c604f51f-29d1-4a6c-941a-36b13e0b1292.png)
