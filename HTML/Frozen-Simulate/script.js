function NotFoundError() {

    //let LoginButton = document.getElementById('Login')

    let UserNameText = document.getElementById('UserName')
    let PasswordText = document.getElementById('Password')

    if(UserNameText.value == 'Sakamochan' && PasswordText.value == 'test-15')
    {
        //URL
        const browse = 'https://pop-apple.github.io/Frozen-Simulate/Freeze/'
        window.location.href = browse
    }
    else
    {

        if(UserNameText.value == 'Sakamochan')
        {
            PasswordText.value = null
            let NoPassword = 'パスワードが正しくありません\n\n画面上の緑枠内のパスワードを使用して下さい。'
            alert(NoPassword)
        }
        else if (PasswordText.value == 'test-15')
        {
            UserNameText.value = null
            let NoUserName = 'ユーザーネームが正しくありません\n\n画面上の緑枠内ユーザーネームを使用して下さい。'
            alert(NoUserName)
        }
        else
        {
            UserNameText.value = null
            PasswordText.value = null
            let Error = 'リクエスト処理中に問題が発生しました\n\nユーザーネームとパスワードが間違っています\n\nやり直してください。'
            alert(Error)
        }
    }
}

function Github() {
    
    const GithubAccount = 'https://github.com/Pop-Apple'
    window.open(GithubAccount, '_blank')

    console.log('Successfully ...')
}