namespace CybersecurityAwarenessBot_POE_Part_2
{
    public class Arrays
    {
        private readonly List<(string Question, string Answer)> qaPairs;
        private Dictionary<string, List<string>> randomResponses;
        private readonly Dictionary<string, string> keywordResponses;

        public Arrays()
        {
            qaPairs = new List<(string, string)>
            {
                ("How are you?", "I'm just a bot, but I'm functioning optimally!"),
                ("What is your purpose?", "I am here to help you with cybersecurity tips and best practices."),
                ("What can I ask you about?", "You can ask me about password safety, phishing, safe browsing, and more!"),
                ("How can I create a strong password?", "Use a mix of uppercase, lowercase, numbers, and symbols. Avoid common words and use at least 12 characters."),
                ("What is phishing?", "Phishing is a cyber-attack where attackers impersonate trustworthy entities to steal sensitive information."),
                ("How can I browse safely online?", "Avoid clicking suspicious links, use HTTPS websites, and keep your software updated."),
                ("What makes a password weak?", "Weak passwords are short, use common words or phrases, and lack a mix of character types. They are easy for attackers to guess or crack using automated tools."),
                ("How often should I change my passwords?", "It's a good practice to change your passwords every 3-6 months, or immediately if you suspect any compromise. Regular updates enhance security."),
                ("What is two-factor authentication (2FA)?", "Two-factor authentication is an extra layer of security that requires not just a password and username but also something that only the user has on them. This can be a piece of information only they know or a physical device, like a phone, to verify their identity."),
                ("How can I recognize a phishing email?", "Look for signs like generic greetings, urgent requests, suspicious links or attachments, and grammatical errors. Always verify the sender's email address and be cautious of unexpected requests for personal information."),
                ("What should I do if I suspect I've been phished?", "Immediately change your passwords, run a full system scan with updated antivirus software, and report the incident to your email provider or relevant authorities. Monitor your accounts for any unusual activity."),
                ("How can I ensure my online accounts are secure?", "Use strong, unique passwords for each account, enable two-factor authentication, keep your software and apps updated, and be cautious of phishing attempts."),
                ("What is the importance of using HTTPS websites?", "HTTPS ensures that the data exchanged between your browser and the website is encrypted, protecting it from eavesdroppers and man-in-the-middle attacks. It's crucial for secure browsing, especially when entering sensitive information."),
                ("How can I protect my personal information online?", "Limit the amount of personal information you share, use privacy settings on social media, be cautious of public Wi-Fi, and only provide information to trusted and secure websites."),
                ("What are some common types of cyber threats?", "Common cyber threats include malware, phishing, ransomware, denial-of-service attacks, and data breaches. Each poses different risks and requires specific precautions."),
                ("How can I secure my home Wi-Fi network?", "Use a strong, unique password for your router, enable network encryption (WPA3 if available), keep your router's firmware updated, and limit access to trusted devices."),
                ("What is a password manager and should I use one?", "A password manager is a tool that securely stores and manages your passwords. Using one can help you create and remember strong, unique passwords for each of your accounts, enhancing your overall security."),
                ("How can I secure my email account?", "Use a strong, unique password, enable two-factor authentication, be cautious of phishing emails, and avoid accessing your email on public computers or unsecured Wi-Fi networks. Regularly review your account settings and activity."),
                ("What is the difference between HTTP and HTTPS?", "HTTP (HyperText Transfer Protocol) is the foundation of data communication on the web, but it's not secure. HTTPS (HTTP Secure) encrypts data exchanged between your browser and the website, protecting it from interception and eavesdropping."),
                ("How can I protect my mobile device from cyber threats?", "Keep your device and apps updated, use strong passwords or biometric authentication, only download apps from trusted sources, and be cautious of public Wi-Fi networks. Additionally, enable remote wipe capabilities in case your device is lost or stolen."),
                ("What is a VPN and how does it enhance security?", "A Virtual Private Network (VPN) creates a secure, encrypted connection between your device and the internet, hiding your IP address and protecting your data from eavesdroppers. It's especially useful when using public Wi-Fi or accessing region-restricted content."),
                ("How can I safely use public Wi-Fi?", "Avoid accessing sensitive information, use a VPN to encrypt your data, keep your software updated, and disable automatic connection to Wi-Fi networks. Always confirm the network name with the provider before connecting."),
                ("What is a data breach and how can it affect me?", "A data breach occurs when unauthorized individuals gain access to confidential information. It can lead to identity theft, financial loss, and other forms of cybercrime. Regularly monitoring your accounts and credit reports can help you detect and respond to breaches early."),
                ("How can I secure my online banking and shopping?", "Use strong, unique passwords, enable two-factor authentication, only shop on secure (HTTPS) websites, and be cautious of phishing attempts. Regularly monitor your bank statements and report any suspicious activity immediately."),
                ("What is a secure way to share files online?", "Use encrypted file-sharing services, set strong passwords for shared files, and limit access to trusted individuals. Avoid sharing sensitive information over unsecured channels like email or public file-sharing platforms."),
                ("How can I protect my business from cyber threats?", "Implement a comprehensive cybersecurity strategy that includes employee training, regular software updates, strong access controls, and incident response planning. Conduct regular security audits and risk assessments to identify and address vulnerabilities."),
                ("What is a DDoS attack and how can it be mitigated?", "A Distributed Denial-of-Service (DDoS) attack overwhelms a target's resources with excessive traffic, making it unavailable to users. Mitigation strategies include using content delivery networks (CDNs), rate limiting, and implementing anti-DDoS solutions from specialized providers."),
                ("How can I secure my social media accounts?", "Use strong, unique passwords, enable two-factor authentication, limit the amount of personal information you share, and be cautious of friend requests and messages from strangers. Regularly review your privacy settings and account activity."),
                ("What is the importance of regular software updates?", "Software updates often include security patches that fix known vulnerabilities. Keeping your software up-to-date helps protect your devices and data from cyber threats that exploit these vulnerabilities."),
                ("How can I dispose of old electronic devices securely?", "Wipe all data using specialized software or perform a factory reset, remove any storage devices (like SSDs or hard drives), and recycle the device through a certified e-waste recycler. Ensure that your data is unrecoverable before disposal to protect your personal information."),
                ("What is social engineering in the context of cybersecurity?", "Social engineering involves manipulating people into divulging confidential information or performing actions that compromise security. It exploits human psychology and trust, often through tactics like phishing, pretexting, or baiting."),
                ("How can I protect my children from online threats?", "Educate them about online safety, set parental controls, monitor their activity, and encourage open communication about their online experiences. Teach them to be cautious of strangers, protect their personal information, and recognize potential threats."),
                ("How can I secure my smart home devices?", "Change default passwords to strong, unique ones, keep firmware updated, disable unnecessary features, and use a separate network for smart devices. Be cautious of devices from unknown or untrusted manufacturers."),
                ("What is multi-factor authentication (MFA)?", "Multi-factor authentication is a security process that requires more than one method of authentication from independent categories of credentials to verify the user's identity for a login or other transaction. It adds an extra layer of security to your accounts.")
            };

            randomResponses = new Dictionary<string, List<string>>
            {
                {
                    "phishing tips", new List<string>
                    {
                        "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organizations.",
                        "Check the sender's email address carefully. Phishing emails often use addresses that look similar to legitimate ones but have slight differences.",
                        "Avoid clicking on links in unsolicited emails. Instead, go directly to the organization's website by typing the URL into your browser.",
                        "Look for signs of urgency or threats in the email. Phishing emails often try to create a sense of urgency to trick you into acting quickly.",
                        "Be wary of emails with poor grammar or spelling mistakes. These are often signs of a phishing attempt."
                    }
                },
                {
                    "password tips", new List<string>
                    {
                        "Use a unique password for each of your accounts to minimize the risk if one password is compromised.",
                        "Consider using a password manager to generate and store complex passwords securely.",
                        "Change your passwords regularly, especially for sensitive accounts like email and banking.",
                        "Avoid using easily guessable information like birthdays or names in your passwords.",
                        "Use multi-factor authentication (MFA) wherever possible to add an extra layer of security."
                    }
                }
            };

            keywordResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "password", "Strong passwords are crucial! Use a mix of letters, numbers, and symbols, and never reuse passwords across sites." },
                { "scam", "Watch out for scams! Always verify unexpected messages and never share sensitive information with untrusted sources." },
                { "privacy", "Protect your privacy by limiting the personal information you share online and reviewing your privacy settings regularly." }
            };
        }

        public void DisplaySampleQuestions()
        {
            int count = 0;
            foreach (var (question, _) in qaPairs)
            {
                if (++count > 5) break;
                Console.WriteLine($"- {question}");
                Thread.Sleep(250);
            }

            Console.WriteLine("- Show more questions");
        }

        public void DisplayAllQuestions()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nFull Question List:\n");
            for (int i = 0; i < qaPairs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {qaPairs[i].Question}");
                Thread.Sleep(100);
            }

            Console.ResetColor();
        }

        public string GetAnswer(string userQuestion)
        {
            try
            {
                // Keyword recognition
                foreach (var keyword in keywordResponses.Keys)
                {
                    if (userQuestion.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                        return keywordResponses[keyword];
                }

                // Random responses
                foreach (var topic in randomResponses.Keys)
                {
                    if (userQuestion.IndexOf(topic, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Random random = new Random();
                        List<string> responses = randomResponses[topic];
                        return responses[random.Next(responses.Count)];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return "I’m not sure I understand. Can you try rephrasing?";
        }
    }
}
