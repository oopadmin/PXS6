🧩 PXS6 — Polybius 6x6 + XOR + Shuffle
The name might say “Polybius,” but the cipher doesn’t actually use Polybius 😉


📘 Overview

PXS6 is an experimental two-way encryption and decryption tool that combines multiple lightweight cryptographic operations for research and educational purposes.


🔧 Core Mechanisms

 - XOR Encryption using a SHA-256 key (chunk[0–5])

 - Shuffle Operation based on random.seed(chunk[6])

 - Checksum Generation via SHA-256(message + chunk[7])


🚀 Usage Guide
🔒 Encryption

 - Requirements:

    - Secret__Key may include characters from:

      [A–Z, a–z, 0–9, ! # $ % & ( ) * + - / < = > ? @ [ \ ] ^ _ { | } ~]


    - Message may include characters from:

      [A–Z, 0–9, space]


 - Output:

    - The encryption process generates a SHA-256 hash used as a checksum to verify message integrity.

🔓 Decryption

 - Requirements:

    - Same character rules as encryption.

 - Verification Logic:

    - When a stored checksum is provided:

        - ✅ [VERIFY] → The original message has not been modified

        - ⚠️ [FALSIFY] → The message has been tampered with

        - 🔁 If the decrypted target matches the checksum, data integrity is confirmed.


🧠 Notes

PXS6 is a conceptual cipher, not intended for production-grade cryptographic use.

Designed for learning, experimentation, and exploring data integrity verification concepts.
