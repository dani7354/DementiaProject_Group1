const chat = document.querySelector('.js-chat')
const messageContainer = document.querySelector('.js-messageContainer')
const inputForm = document.querySelector('.js-inputForm')
const inputField = document.querySelector('.js-inputField')
const dots = document.querySelector('.js-dots')

inputForm.addEventListener('submit', (e) => {
    e.preventDefault()

    if (userMessage === 'clear') {
        Clear()
    } else if (!userMessage) {
        return
    } else {
        ShowUserMessage()
        GetReply()

        if (messageContainer.scrollHeight > messageContainer.clientHeight) {
            chat.classList.add('Chat--overflown')
        }
    }

    inputForm.reset()
})

function ShowUserMessage() {
    let userMessage = inputField.value
    let messageDiv = document.createElement('div')
    let messageBubble = `<span class="Chat-bubble">${userMessage}</span>`

    messageDiv.classList.add('Chat-message', 'Chat-message--user')
    messageDiv.innerHTML += messageBubble;
    messageContainer.insertBefore(messageDiv, dots)
    messageContainer.classList.add('Chat-messages--typing')
}

function ShowReply(reply) {
    let messageDiv = document.createElement('div')
    let messageBubble = `<span class="Chat-bubble">${reply}</span>`

    messageDiv.classList.add('Chat-message', 'Chat-message--bot')
    messageDiv.innerHTML += messageBubble;
    messageContainer.insertBefore(messageDiv, dots)
}

function GetReply() {
    $.ajax({
        type: 'POST',
        url: '/message/reply',
        data: {
            message: $('.js-inputField').val()
        },
        dataType: 'json',
        success: function (response) {
            ShowReply(response.reply)
        },
    })
}

function Clear() {
    const messages = document.querySelectorAll('.Chat-message')

    messages.forEach(message => {
        if (message.classList.contains('js-dots')) {
            return
        } else {
            message.remove()
        }
    })

    chat.classList.remove('Chat--overflown')
    messageContainer.classList.remove('Chat-messages--typing')
}