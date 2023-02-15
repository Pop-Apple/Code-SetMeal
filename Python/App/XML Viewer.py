Title = '\n' + '【 XML Entry Name Viewer 】'

print(Title)

def Re():
	
	print('\n' + '[ Enter The Directory ]' + '\n')

	path=input("> ")

	with open(path,encoding="utf-8") as f:
		s=f.readlines()
		f.close
	for x in range(len(s)):
		if('<entry name="' in s[x])==True:
			Alt=s[x].replace('\n','')
			Alt=Alt.replace('<entry name="','')
			Alt=Alt.replace('">','')
			print(Alt)
	Re()
Re()
