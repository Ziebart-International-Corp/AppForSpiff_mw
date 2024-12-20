from flask import Flask, request, jsonify
import json
from difflib import get_close_matches
from flask_cors import CORS
import logging

app = Flask(__name__)

logging.basicConfig(level=logging.INFO)

# Load the knowledge base
def load_knowledge_base(file_path: str) -> dict:
    try:
        with open(file_path, 'r') as f:
            return json.load(f)
    except FileNotFoundError:
        return {"questions": []}  # Default empty knowledge base

# Save the knowledge base
def save_knowledge_base(knowledge_base: dict, file_path: str):
    with open(file_path, 'w') as f:
        json.dump(knowledge_base, f, indent=2)

# Find the best match
def find_best_match(user_question: str, questions: list[str]):
    matches = get_close_matches(user_question, questions, n=1, cutoff=0.8)
    return matches[0] if matches else None

# Get an answer from the knowledge base
def get_answer(user_question: str, knowledge_base: dict):
    user_question = user_question.lower()
    questions = {q["question"].lower(): q["answer"] for q in knowledge_base["questions"]}
    if user_question in questions:
        return questions[user_question]
    
    best_match = find_best_match(user_question, list(questions.keys()))
    if best_match:
        return questions[best_match]
    
    return None

@app.route('/chat', methods=['POST'])
def chat():
    logging.info(f"Request received: {request.json}")
    data = request.json
    user_question = data.get("question")
    new_answer = data.get("new_answer")  # Optional parameter for teaching

    if not user_question:
        return jsonify({"error": "No question provided"}), 400

    logging.info(f"Received question: {user_question}")

    file_path = 'knowledge_base.json'
    knowledge_base = load_knowledge_base(file_path)

    # Check for an existing answer
    answer = get_answer(user_question, knowledge_base)
    if answer:
        return jsonify({"answer": answer})
    elif new_answer:
        # Teach the bot
        knowledge_base["questions"].append({"question": user_question, "answer": new_answer})
        save_knowledge_base(knowledge_base, file_path)
        return jsonify({"answer": "Thanks! I've learned this new answer."})
    else:
        return jsonify({"answer": "Sorry, I don't know the answer to that question."})

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000, debug=True)
