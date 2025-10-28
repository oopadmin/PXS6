# Project: PXS6 == Polybius 6x6 + Xor + Shuffle
tên vậy thôi chứ không có dùng Polybius :]

## Giới thiệu
 - Tool mã hóa 2 chiều thử nghiệm kết hợp
	- Xor với khóa SHA-256 [chunk 0-5]
	- Shuffle với random.seed(chunk 6)
	- Checksum = SHA-256(message + chunk 7)

## Hướng dẫn sử dụng
 - Encrypt
	- Secret__Key in [A-Z , a-z , 0-9 , !#$%&()*+-/<=>?@[\]^_{|}~] 
	- Message in [A-Z , 0-9 ,  ]

 - Decrypt
	- như trên
	- nếu phần target == checksum thì là [data integrity]