const messageContainer = document.querySelector('.js-messageContainer')
const inputForm = document.querySelector('.js-inputForm')
const inputField = document.querySelector('.js-inputField')
const dots = document.querySelector('.js-dots')

inputForm.addEventListener('submit', (e) => {
    const userMessage = inputField.value
    const messageDiv = document.createElement('div')
    const messageBubble = `<span class="Chat-bubble">${userMessage}</span>`

    messageDiv.classList.add('Chat-message', 'Chat-message--user')
    messageDiv.innerHTML += messageBubble;

    messageContainer.insertBefore(messageDiv, dots)
    messageContainer.classList.add('Chat-messages--typing')

    e.preventDefault()

});

function ShowReply(reply) {
    const messageDiv = document.createElement('div')
    let messageBubble = `<span class="Chat-bubble">${reply}</span>`
    messageDiv.classList.add('Chat-message', 'Chat-message--bot')
    messageDiv.innerHTML += messageBubble;
    messageContainer.insertBefore(messageDiv, dots)
}

// Event fired when the input form is submitted (when <enter> is pressed)
$(document).ready(function () {
    $(".js-inputForm").submit(function () {
        $.ajax({
            type: "POST",
            url: '/message/reply', 
            data: {
                message: $(".js-inputField").val()
            },
            dataType: 'json',
            success: function (response) {
                ShowReply(response.reply);
            },
        });
        inputForm.reset();
    });
});
